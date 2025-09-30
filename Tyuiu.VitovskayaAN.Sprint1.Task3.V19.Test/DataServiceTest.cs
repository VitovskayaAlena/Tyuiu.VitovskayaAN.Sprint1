﻿using System.Transactions;
using Tyuiu.VitovskayaAN.Sprint1.Task3.V19.Lib;
namespace Tyuiu.VitovskayaAN.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 2;
            double y1 = 1;
            double y2 = 2;
            var wait = true;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(wait, res);
        }
    }
}
