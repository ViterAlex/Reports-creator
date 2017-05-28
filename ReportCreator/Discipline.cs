namespace ReportCreator
{
    public class Discipline : AcademicLoad
    {
        /// <summary>
        /// Формы промежуточной аттестации
        /// </summary>
        public string[] MidtermAssessment { get; } = new string[8];
        /// <summary>
        /// Распределение обязательной нагрузки
        /// </summary>
        public int[] WorkloadDistribution { get; } = new int[8];

        public Discipline(string index)
            : base(index) { }

        public Discipline()
            : base()
        {
            
        }
    }
}
