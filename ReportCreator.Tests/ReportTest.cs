using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReportCreator.Tests
{
    [TestClass]
    public class ReportTest
    {
        private static Report _report;
        readonly string[] _names = {
                                       "Русский язык",
                                       "Литература",
                                       "Иностранный языкИстория",
                                       "Физическая культура",
                                       "Основы безопасности жизнедеятельности",
                                       "Химия",
                                       "Обществознание",
                                       "Биология",
                                       "География",
                                       "Экология"
                                   };

        readonly string[] _assessement = { "ДЗ", "Э", string.Empty };

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _report = new Report(Path.GetFullPath("gridTemplate.dotx"), true);
        }

        [TestMethod]
        public void Constructor_Doesnt_Throw_Exception()
        {
            try
            {
                new Report(Path.GetFullPath("gridTemplate.dotx"));
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void AddCategory_Doesnt_Throw_Exception()
        {
            try
            {
                var cat = new Category("ОД")
                {
                    Title = "Общеобразовательная подготовка",
                    MaxLoad = 2106,
                    SelfGuided = 702,
                    StatutoryLoad = new StatutoryLoad
                    {
                        Total = 1404,
                        LIZWithoutDivision = 184,
                        LIZWithDivision = 299
                    }
                };
                _report.AddCategory(cat);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void AddDisciplines_Doesnt_Throw_Exception()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            List<Discipline> discs = new List<Discipline>();
            for (var i = 0; i < _names.Length; i++)
            {
                var disc = new Discipline
                {
                    Index = $"ОУД{i:00}",
                    Title = _names[i],
                    MaxLoad = rnd.Next(20, 100),
                    SelfGuided = rnd.Next(20, 100),
                    StatutoryLoad = new StatutoryLoad
                    {
                        Total = rnd.Next(200, 500),
                        LIZWithoutDivision = rnd.Next(10, 35),
                        LIZWithDivision = rnd.Next(50, 60)
                    }
                };
                for (var j = 0; j < disc.MidtermAssessment.Length; j++)
                {
                    var index = rnd.Next(_assessement.Length);
                    disc.MidtermAssessment[j] = _assessement[index];
                }
                for (var j = 0; j < disc.WorkloadDistribution.Length; j++)
                {
                    disc.WorkloadDistribution[j] = rnd.Next(50);
                }
                discs.Add(disc);
            }

            try
            {
                _report.AddDisciplines(discs);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void AddDiscipline_Doesnt_Throw_Exception()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int i = rnd.Next(_names.Length);
            var d = new Discipline
            {
                Index = $"ОУД{i:00}",
                Title = _names[i],
                MaxLoad = rnd.Next(20, 100),
                SelfGuided = rnd.Next(20, 100),
                StatutoryLoad = new StatutoryLoad
                {
                    Total = rnd.Next(200, 500),
                    LIZWithoutDivision = rnd.Next(10, 35),
                    LIZWithDivision = rnd.Next(50, 60)
                }
            };
            for (var j = 0; j < d.MidtermAssessment.Length; j++)
            {
                var index = rnd.Next(_assessement.Length);
                d.MidtermAssessment[j] = _assessement[index];
            }
            for (var j = 0; j < d.WorkloadDistribution.Length; j++)
            {
                d.WorkloadDistribution[j] = rnd.Next(50);
            }

            try
            {
                _report.AddDiscipline(d);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
