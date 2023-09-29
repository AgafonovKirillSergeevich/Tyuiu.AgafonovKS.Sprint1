using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint1.Task3.V1.Lib;

namespace Tyuiu.AgafonovKS.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 4;
            double h = 5;
            double wait = 251,2;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);
        }
    }
}
