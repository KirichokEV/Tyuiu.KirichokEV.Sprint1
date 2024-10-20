using Tyuiu.KirichokEV.Sprint1.Task4.V8.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task4.V8
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
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #8                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,           *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                          *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Sqrt(|x-y|) + 3*x / 3 + |x| = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
