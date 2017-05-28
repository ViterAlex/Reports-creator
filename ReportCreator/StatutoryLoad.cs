namespace ReportCreator
{
    /// <summary>
    /// Обязательная нагрузка
    /// </summary>
    public class StatutoryLoad
    {
        /// <summary>
        /// Всего
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// ЛИЗ без деления
        /// </summary>
        public int LIZWithoutDivision { get; set; }
        /// <summary>
        /// ЛИЗ с делением
        /// </summary>
        public int LIZWithDivision { get; set; }
        /// <summary>
        /// Курсовой проект (работа)
        /// </summary>
        public int TermProject { get; set; }
    }
}
