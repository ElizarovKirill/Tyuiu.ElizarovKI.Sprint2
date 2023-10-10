using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint2.Task3.V23.Lib;

namespace Tyuiu.ElizarovKI.Sprint2.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditiob1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditiob2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -5.333;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditiob3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidConditiob4()
        {
            DataService ds = new DataService();
            double x = -28;
            double res = ds.Calculate(x);
            double wait = -308.001;
            Assert.AreEqual(wait, res);
        }
    }
}
