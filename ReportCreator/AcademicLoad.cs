namespace ReportCreator
{
    public abstract class AcademicLoad
    {
        protected AcademicLoad(string index)
        {
            Index = index;
        }

        protected AcademicLoad()
        {

        }
        /// <summary>
        /// Название категории или дисциплины
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Индекс
        /// </summary>
        public string Index { get; set; }
        /// <summary>
        /// Максимальная нагрузка
        /// </summary>
        public int MaxLoad { get; set; }
        /// <summary>
        /// Самостоятельная работа
        /// </summary>
        public int SelfGuided { get; set; }
        /// <summary>
        /// Обязательная нагрузка
        /// </summary>
        public StatutoryLoad StatutoryLoad { get; set; } = new StatutoryLoad();
    }
}
