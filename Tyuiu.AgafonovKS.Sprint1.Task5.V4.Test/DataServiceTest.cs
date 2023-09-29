using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint1.Task5.V4.Lib;

namespace Tyuiu.AgafonovKS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int time = 3;
            DataService ds = new DataService();
            int res = ds.SecondsToHours(time);

            int result = Convert.ToInt32(res);

            int wait = 0;
            Assert.AreEqual(result, wait);
        }
    }
}