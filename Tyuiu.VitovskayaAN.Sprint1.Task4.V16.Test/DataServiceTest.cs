using Tyuiu.VitovskayaAN.Sprint1.Task4.V16.Lib;
namespace Tyuiu.VitovskayaAN.Sprint1.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 23;
            double wait = 0.037;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
