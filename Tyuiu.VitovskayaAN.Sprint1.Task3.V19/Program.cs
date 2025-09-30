using Tyuiu.VitovskayaAN.Sprint1.Task3.V19.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнила: Витовская А. Н. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнила: Витовская Алёна Николаевна | РППб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая печатает true или false в зависимости       *");
        Console.WriteLine("* от того, может ли шахматная фигура «Слон» с одного заданного поля       *");
        Console.WriteLine("* шахматной доски перейти за один ход на другое.                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение x1:");
        var x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение x2:");
        var x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y1:");
        var y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y2:");
        var y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Может ли шахматная фигура «Слон» с одного заданного поля шахматной доски перейти за один ход на другое = " + ds.ElephCanMove(x1, x2, y1, y2));
        Console.ReadKey();
    }
}