using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VitovskayaAN.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            var res = (x - (Math.Pow(10, Math.Sin(x))) + (20 * Math.Pow(x, 2) / (3 * Math.Pow(x, 3))) + Math.Cos(Math.Pow(x, 2) - y));
            return Math.Round(res, 3);
        }
    }
}
