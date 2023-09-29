using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AgafonovKS.Sprint1.Task6.V15.Lib;

namespace Tyuiu.AgafonovKS.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidExpression()
        {
            string strTest = "zxcv.";
            DataService ds = new DataService();
            string res = ds.CheckLettersCount(strTest);
            string wait = "zxcv";
            Assert.AreEqual(wait, res);
        }
    }
}