using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint1.Task7.V7.Lib;

namespace Tyuiu.AgafonovKS.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 28.753;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}