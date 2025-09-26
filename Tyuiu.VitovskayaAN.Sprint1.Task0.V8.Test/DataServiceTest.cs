using Tyuiu.VitovskayaAN.Sprint1.Task0.V8.Lib;
namespace Tyuiu.VitovskayaAN.Sprint1.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate();
            Assert.AreEqual(1.875, res);
        }
    }
}