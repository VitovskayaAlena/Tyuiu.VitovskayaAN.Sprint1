using Tyuiu.VitovskayaAN.Sprint1.Task5.V4.Lib;
namespace Tyuiu.VitovskayaAN.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 13257;
            DataService ds = new DataService();
            double res = ds.SecondsToHours(k);
            int result = Convert.ToInt32(res);
            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
