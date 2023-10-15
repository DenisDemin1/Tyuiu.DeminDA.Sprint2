using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint2.Task6.V14.Lib;
namespace Tyuiu.DeminDA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int day = 2;
            int week = 2;
            string res = ds.FindDayName(day, week);
            string wait = "Среда";
            Assert.AreEqual(res,wait);
        }
    }
}
