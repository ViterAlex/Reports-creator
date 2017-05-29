using System;
using System.Windows.Forms;
using ReportCreator;

namespace ReportForms
{
    public partial class DisciplineEditor : UserControl, IEditor
    {
        /// <summary>
        /// Редактируемая дисциплина
        /// </summary>
        public Discipline Discipline { get; private set; }

        public DisciplineEditor()
        {
            InitializeComponent();
        }

        public DisciplineEditor(Discipline discipline)
            : this()
        {
            midtermAssessementDataGridView.CellValueNeeded += MidtermAssessementDataGridView_CellValueNeeded; ;
            midtermAssessementDataGridView.CellValuePushed += MidtermAssessementDataGridView_CellValuePushed;
            workloadDistributionDataGridView.CellValueNeeded += WorkloadDistributionDataGridView_CellValueNeeded;
            workloadDistributionDataGridView.CellValuePushed += WorkloadDistributionDataGridView_CellValuePushed; 
            Build(discipline);
        }

        private void WorkloadDistributionDataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            Discipline.WorkloadDistribution[e.ColumnIndex] = (int)e.Value;
        }

        private void WorkloadDistributionDataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            e.Value = Discipline.WorkloadDistribution[e.ColumnIndex];
        }

        private void MidtermAssessementDataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            Discipline.MidtermAssessment[e.ColumnIndex] = e.Value.ToString();
        }

        private void MidtermAssessementDataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            e.Value = Discipline.MidtermAssessment[e.ColumnIndex];
        }

        #region Implementation of IEditor

        public event EventHandler Applied;

        public void Build(Discipline discipline)
        {
            Discipline = discipline;
            midtermAssessementDataGridView.Rows.Clear();
            midtermAssessementDataGridView.Rows.Add();
            workloadDistributionDataGridView.Rows.Clear();
            workloadDistributionDataGridView.Rows.Add();

            indexTextBox.Text = Discipline.Index;
            titleTextBox.Text = Discipline.Title;
            statutoryLoadTotalNumericUpDown.Value = Discipline.MaxLoad;
            selfGuidedHoursNumericUpDown.Value = Discipline.SelfGuided;
            if (Discipline.StatutoryLoad == null)
            {
                Discipline.StatutoryLoad = new StatutoryLoad();
            }
            statutoryLoadTotalNumericUpDown.Value = Discipline.StatutoryLoad.Total;
            lizWithoutDivisionNumericUpDown.Value = Discipline.StatutoryLoad.LIZWithoutDivision;
            lizWithDivisionNumericUpDown.Value = Discipline.StatutoryLoad.LIZWithDivision;
            termProjectNumericUpDown.Value = Discipline.StatutoryLoad.TermProject;
        }

        #endregion

        protected virtual void OnApplied()
        {
            Applied?.Invoke(this, EventArgs.Empty);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Discipline.Index = indexTextBox.Text;
            Discipline.Title = titleTextBox.Text;
            Discipline.MaxLoad = (int)statutoryLoadTotalNumericUpDown.Value;
            Discipline.SelfGuided = (int)selfGuidedHoursNumericUpDown.Value;
            if (Discipline.StatutoryLoad == null)
            {
                Discipline.StatutoryLoad = new StatutoryLoad();
            }
            Discipline.StatutoryLoad.Total = (int)statutoryLoadTotalNumericUpDown.Value;
            Discipline.StatutoryLoad.LIZWithoutDivision = (int)lizWithoutDivisionNumericUpDown.Value;
            Discipline.StatutoryLoad.LIZWithDivision = (int)lizWithDivisionNumericUpDown.Value;
            Discipline.StatutoryLoad.TermProject = (int)termProjectNumericUpDown.Value;
            OnApplied();
        }
    }
}
