using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint2.Task5.V7.Lib;

namespace Tyuiu.ElizarovKI.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startYear = 1990;

            Assert.AreEqual("Февраль", ds.FindMonthName(startYear, 1));
            Assert.AreEqual("Март", ds.FindMonthName(startYear, 2));
            Assert.AreEqual("Апрель", ds.FindMonthName(startYear, 3));
            Assert.AreEqual("Май", ds.FindMonthName(startYear, 4));
            Assert.AreEqual("Июнь", ds.FindMonthName(startYear, 5));
            Assert.AreEqual("Июль", ds.FindMonthName(startYear, 6));
            Assert.AreEqual("Август", ds.FindMonthName(startYear, 7));
            Assert.AreEqual("Сентябрь", ds.FindMonthName(startYear, 8));
            Assert.AreEqual("Октябрь", ds.FindMonthName(startYear, 9));
            Assert.AreEqual("Ноябрь", ds.FindMonthName(startYear, 10));
            Assert.AreEqual("Декабрь", ds.FindMonthName(startYear, 11));
            Assert.AreEqual("Январь", ds.FindMonthName(startYear, 12));
        }
    }
}
