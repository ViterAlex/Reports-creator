using System;
using System.Collections.Generic;
using System.Globalization;

namespace ReportCreator
{
    public class Report : IDisposable
    {
        private const float CENTIMETRES_TO_POINTS = 28.34646f;
        private dynamic _wdDoc;
        private dynamic _wdApp;
        /// <summary>
        /// Создание нового экземпляра отчёта на основе шаблона.
        /// </summary>
        /// <param name="template">Путь к шаблону.</param>
        /// <param name="visible">Показывать ли окно приложения во время работы.</param>
        public Report(string template, bool visible = false)
        {
            NewDoc(template, visible);
        }

        private void NewDoc(string template, bool visible)
        {
            OpenApp(visible);
            CreateDoc(template);
        }

        private void OpenApp(bool visible)
        {
            var type = Type.GetTypeFromProgID("Word.Application", false);
            if (type == null)
            {
                throw new InvalidOperationException("Не удалось запустить приложение Word. Возожно оно не установлено.");
            }
            _wdApp = Activator.CreateInstance(type);
            _wdApp.Visible = visible;
        }

        private void CreateDoc(string template)
        {
            _wdDoc = _wdApp.Documents.Add(Template: template);
        }
        /// <summary>
        /// Добавление категории в документ.
        /// </summary>
        public void AddCategory(Category category)
        {
            var table = AddRow();

            var row = (int)table.Rows.Count;
            table.Cell(row, 1).Range.Font.Bold = 1;
            table.Cell(row, 2).Range.Font.Bold = 1;

            table.Cell(row, 1).Range.Text = category.Index;
            table.Cell(row, 2).Range.Text = category.Title;
            
            table.Cell(row, 11).Range.Text = category.MaxLoad.GetString();
            table.Cell(row, 12).Range.Text = category.SelfGuided.GetString();
            table.Cell(row, 13).Range.Text = category.StatutoryLoad.Total.GetString();

            table.Cell(row, 14).Range.Text = category.StatutoryLoad.LIZWithoutDivision.GetString();
            table.Cell(row, 14).Range.Orientation = 0;//wdTextOrientationHorizontal;

            table.Cell(row, 15).Range.Text = category.StatutoryLoad.LIZWithDivision.GetString();
            table.Cell(row, 15).Range.Orientation = 0;//wdTextOrientationHorizontal;

            table.Cell(row, 16).Range.Text = category.StatutoryLoad.TermProject.GetString();
            table.Cell(row, 16).Range.Orientation = 0;//wdTextOrientationHorizontal;

            AutoSizeRow(table, row);
        }
        /// <summary>
        /// Сохранение документа.
        /// </summary>
        /// <param name="fileName">Полный путь к файлу.</param>
        public void Save(string fileName)
        {
            float appVersion = float.Parse(_wdApp.Version.ToString(), CultureInfo.InvariantCulture);
            if (appVersion < 14)
            {
                _wdDoc.SaveAs(fileName);
            }
            else
            {
                _wdDoc.SaveAs2(fileName);
            }
        }
        /// <summary>
        /// Добавление дисциплины в список.
        /// </summary>
        public void AddDiscipline(Discipline discipline)
        {
            var table = AddRow();
            var row = (int)table.Rows.Count;
            table.Cell(row, 1).Range.Font.Bold = 0;
            table.Cell(row, 2).Range.Font.Bold = 0;

            table.Cell(row, 1).Range.Text = discipline.Index;
            table.Cell(row, 2).Range.Text = discipline.Title;

            for (var i = 0; i < discipline.MidtermAssessment.Length; i++)
            {
                table.Cell(row, i + 3).Range.Text = discipline.MidtermAssessment[i];
            }

            table.Cell(row, 11).Range.Text = discipline.MaxLoad.GetString();
            table.Cell(row, 12).Range.Text = discipline.SelfGuided.GetString();
            table.Cell(row, 13).Range.Text = discipline.StatutoryLoad?.Total.GetString();

            table.Cell(row, 14).Range.Text = discipline.StatutoryLoad?.LIZWithoutDivision.GetString();
            table.Cell(row, 14).Range.Orientation = 0;//wdTextOrientationHorizontal;

            table.Cell(row, 15).Range.Text = discipline.StatutoryLoad?.LIZWithDivision.GetString();
            table.Cell(row, 15).Range.Orientation = 0;//wdTextOrientationHorizontal;

            table.Cell(row, 16).Range.Text = discipline.StatutoryLoad?.TermProject.GetString();
            table.Cell(row, 16).Range.Orientation = 0;//wdTextOrientationHorizontal;

            for (var i = 0; i < discipline.WorkloadDistribution.Length; i++)
            {
                table.Cell(row, i + 17).Range.Text = discipline.WorkloadDistribution[i].GetString();
            }

            AutoSizeRow(table, row);
        }
        /// <summary>
        /// Добавление нескольких диспциплин.
        /// </summary>
        public void AddDisciplines(IEnumerable<Discipline> disciplines)
        {
            foreach (var discipline in disciplines)
            {
                AddDiscipline(discipline);
            }
        }
        /// <summary>
        /// Добавление строки в таблицу.
        /// </summary>
        /// <returns>Возвращает таблицу с добавленной строкой.</returns>
        private dynamic AddRow()
        {
            var table = _wdDoc.Tables[1];
            table.Rows.Add();
            return table;
        }
        /// <summary>
        /// Подгонка высоты строки.
        /// </summary>
        /// <param name="table">Таблица</param>
        /// <param name="row">Номер строки, начиная с 1.</param>
        /// <param name="height">Минимальная высота</param>
        private static void AutoSizeRow(dynamic table, int row, float height = 0.1f)
        {
            table.Cell(row, 11).Range.Rows.HeightRule = 1;//wdRowHeightAtLeast
            table.Cell(row, 11).Range.Rows.Height = height * CENTIMETRES_TO_POINTS;
        }

        private void Close()
        {
            _wdDoc?.Close();
            _wdApp?.Quit(false);
        }

        #region Implementation of IDisposable

        public void Dispose()
        {
            Close();
        }

        #endregion
    }
}
