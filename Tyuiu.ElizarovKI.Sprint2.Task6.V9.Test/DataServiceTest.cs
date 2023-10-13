using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ElizarovKI.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int m = 3;
            int n = 20;

            Assert.AreEqual("21.03", ds.FindDateOfNextDay(m, n));
        }
    }
}
