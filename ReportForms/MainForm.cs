using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportCreator;

namespace ReportForms
{
    public partial class MainForm : Form
    {
        private readonly List<Category> _categories = new List<Category>();
        private readonly Font _categoryNodeFont;
        private readonly CategoryEditor _categoryEditor = new CategoryEditor();
        private readonly DisciplineEditor _disciplineEditor = new DisciplineEditor();
        private TreeNode _lastSelectedNode;

        public MainForm()
        {
            InitializeComponent();
            treeView1.AfterSelect += TreeView1_AfterSelect;
            _categoryNodeFont = new Font(Font, Font.Style | FontStyle.Bold);
            treeView1.AfterLabelEdit += TreeView1_AfterLabelEdit;
            treeView1.PreviewKeyDown += TreeView1_PreviewKeyDown;
            treeView1.LabelEdit = true;
        }

        private void TreeView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                treeView1.SelectedNode.BeginEdit();
            }
        }

        private void TreeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            var type = e.Node.Tag.GetType();
            if (type == typeof(Category))
            {
                var c = e.Node.Tag as Category;
                c.Index = e.Label;
                _categoryEditor.Build(c);
            }
            else if (type == typeof(Discipline))
            {
                var d = e.Node.Tag as Discipline;
                d.Index = e.Label;
                _disciplineEditor.Build(d);
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _lastSelectedNode = e.Node;
            var type = e.Node.Tag.GetType();
            if (type == typeof(Category))
            {
                _categoryEditor.Build((Category)e.Node.Tag);
                AddControl(_categoryEditor);
            }
            else if (type == typeof(Discipline))
            {
                _disciplineEditor.Build((Discipline)e.Node.Tag);
                AddControl(_disciplineEditor);
            }
        }

        private void AddControl(Control control)
        {
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(control);
            var editor = control as IEditor;
            if (editor == null)
            {
                return;
            }
            editor.Applied -= (sender, args) => UpdateNode();
            editor.Applied += (sender, args) => UpdateNode();
        }

        private void UpdateNode()
        {
            if (_lastSelectedNode == null)
            {
                UpdateTreeView();
                return;
            }
            var type = _lastSelectedNode.Tag.GetType();
            if (type == typeof(Discipline))
            {
                var d = _lastSelectedNode.Tag as Discipline;
                _lastSelectedNode.Text = d.Index;
            }
            else if (type == typeof(Category))
            {
                var c = _lastSelectedNode.Tag as Category;
                _lastSelectedNode.Nodes.Clear();
                foreach (var discipline in c.Disciplines)
                {
                    _lastSelectedNode.Nodes.Add(new TreeNode(discipline.Index)
                    {
                        Tag = discipline
                    });
                }
            }
            _lastSelectedNode.Expand();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _categories.Add(new Category($"Категория{_categories.Count + 1}"));
            UpdateTreeView();
        }

        private void addDisciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _lastSelectedNode = treeView1.SelectedNode;
            if (_lastSelectedNode == null)
            {
                return;
            }
            var cat = _lastSelectedNode.Tag as Category;
            if (cat == null)
            {
                cat = _lastSelectedNode.Parent.Tag as Category;
                _lastSelectedNode = _lastSelectedNode.Parent;
            }
            if (cat == null)
            {
                return;
            }
            cat.Disciplines.Add(new Discipline($"Дисциплина{cat.Disciplines.Count + 1}"));
            UpdateNode();
        }

        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            foreach (var category in _categories)
            {
                var index = treeView1.Nodes.Add(new TreeNode
                {
                    //BUG:Полужирный текст обрезается, если жирность шрифта задавать после задания текста.
                    NodeFont = _categoryNodeFont,
                    Tag = category,
                });
                var catNode = treeView1.Nodes[index];
                catNode.Text = category.Index;

                foreach (var discipline in category.Disciplines)
                {
                    catNode.Nodes.Add(new TreeNode(discipline.Index)
                    {
                        Tag = discipline
                    });
                }
            }
            treeView1.ExpandAll();
        }

        private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateReport(Path.GetFullPath("gridTemplate.dotx")).Save(Path.GetFullPath("newReport.docx"));
        }

        private Report CreateReport(string path)
        {
            var report = new Report(path, true);
            foreach (var category in _categories)
            {
                report.AddCategory(category);
                report.AddDisciplines(category.Disciplines);
            }
            return report;
        }

        private async void CreateReportAsync(string path)
        {
            createReportToolStripMenuItem.Enabled = false;
            var result = await new Task<Report>(() => CreateReport(path));

            result.Save(Path.GetFullPath("newReport.docx"));
            createReportToolStripMenuItem.Enabled = true;
        }
    }
}
