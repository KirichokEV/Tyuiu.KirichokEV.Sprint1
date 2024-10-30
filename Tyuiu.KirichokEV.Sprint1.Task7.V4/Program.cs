using Tyuiu.KirichokEV.Sprint1.Task7.V4.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.Title = "Спринт #1 | Выполнила: Киричoк Е. В.| РППб-24-1";
          
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                                  *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #4                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычиялет математическое выражение по исходным         *");
            Console.WriteLine("* данным, вводимых пользователем.                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("       |       ___             y     |");
            Console.WriteLine("z = ln | (y - /|x|) * (x - ---------)|");
            Console.WriteLine("       |                        2    |");
            Console.WriteLine("       |                   x + x     |");
            Console.WriteLine("       |                      ---    |");
            Console.WriteLine("       |                       4     |");

            double x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
