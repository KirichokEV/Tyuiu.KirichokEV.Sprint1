using Tyuiu.KirichokEV.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Киричoк Е. В.| РППб-24-1";
            //Длина строки 75 символов 
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                                  *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #11                                                                       *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,           *");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране.                       *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            double x1 = -2;
            double y1 = 5;
            double x2 = 1;
            double y2 = 7;
            double x3 = 5;
            double y3 = -3;
            Console.WriteLine("x1 -> " + x1);
            Console.WriteLine("y1 -> " + y1);
            Console.WriteLine("x2 -> " + x2);
            Console.WriteLine("y2 -> " + y2);
            Console.WriteLine("x3 -> " + x3);
            Console.WriteLine("y3 -> " + y3);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Площадь треугольника =" + ds.TriangleArea(x1, y1, x2, y2, x3, y3) + "кв.см");

            Console.ReadKey();
        }
    }
}
