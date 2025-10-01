using Tyuiu.VitovskayaAN.Sprint1.Task6.V10.Lib;
namespace Tyuiu.VitovskayaAN.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "hello word";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(strTest);
            string wait = "helo word";
            Assert.AreEqual(wait, res);
        }
    }
}
