using Tyuiu.VitovskayaAN.Sprint1.Task2.V30.Lib;
namespace Tyuiu.VitovskayaAN.Sprint1.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(0.002, res);
        }
    }
}
