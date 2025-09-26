using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VitovskayaAN.Sprint1.Task2.V30.Lib
{
    public class DataService : ISprint1Task2V30
    {
        public double ConvertKmToMetre(double value)
        {
            return  Math.Round(value / 1000.0, 3);
        }
    }
}
