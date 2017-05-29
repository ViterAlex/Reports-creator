using System.Collections.Generic;

namespace ReportCreator
{
    public class Category : AcademicLoad
    {
        public Category(string index)
            : base(index) { }

        public Category()
            : base()
        {

        }
        /// <summary>
        /// Дисциплины в данной категории
        /// </summary>
        public List<Discipline> Disciplines { get; } = new List<Discipline>();
    }
}
