using System;
using System.Windows.Forms;
using ReportCreator;

namespace ReportForms
{
    public partial class CategoryEditor : UserControl, IEditor
    {
        public Category Category { get; private set; }
        public event EventHandler Applied;
        public CategoryEditor()
        {
            InitializeComponent();
        }

        public CategoryEditor(Category category)
            : this()
        {
            Build(category);
        }

        public void Build(Category category)
        {
            Category = category;
            indexTextBox.Text = Category.Index;
            titleTextBox.Text = Category.Title;
            statutoryLoadTotalNumericUpDown.Value = Category.MaxLoad;
            selfGuidedHoursNumericUpDown.Value = Category.SelfGuided;
            if (Category.StatutoryLoad == null)
            {
                Category.StatutoryLoad = new StatutoryLoad();
            }
            statutoryLoadTotalNumericUpDown.Value = Category.StatutoryLoad.Total;
            lizWithoutDivisionNumericUpDown.Value = Category.StatutoryLoad.LIZWithoutDivision;
            lizWithDivisionNumericUpDown.Value = Category.StatutoryLoad.LIZWithDivision;
            termProjectNumericUpDown.Value = Category.StatutoryLoad.TermProject;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Category.Index = indexTextBox.Text;
            Category.Title = titleTextBox.Text;
            Category.MaxLoad = (int)statutoryLoadTotalNumericUpDown.Value;
            Category.SelfGuided = (int)selfGuidedHoursNumericUpDown.Value;
            if (Category.StatutoryLoad == null)
            {
                Category.StatutoryLoad = new StatutoryLoad();
            }
            Category.StatutoryLoad.Total = (int)statutoryLoadTotalNumericUpDown.Value;
            Category.StatutoryLoad.LIZWithoutDivision = (int)lizWithoutDivisionNumericUpDown.Value;
            Category.StatutoryLoad.LIZWithDivision = (int)lizWithDivisionNumericUpDown.Value;
            Category.StatutoryLoad.TermProject = (int)termProjectNumericUpDown.Value;
            OnApplied();
        }

        protected virtual void OnApplied()
        {
            Applied?.Invoke(this, EventArgs.Empty);
        }

    }
}
