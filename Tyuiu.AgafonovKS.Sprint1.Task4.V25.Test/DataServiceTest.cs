using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint1.Task4.V25.Lib;

namespace Tyuiu.AgafonovKS.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 5;
            double wait = 0.779;
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
        }
    }
}