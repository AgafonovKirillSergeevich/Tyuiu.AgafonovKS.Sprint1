using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint1.Task2.V1.Lib;

namespace Tyuiu.AgafonovKS.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()
        {
            DataService ds = new DataService();
            int x;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(124, res);
        }
    }
}