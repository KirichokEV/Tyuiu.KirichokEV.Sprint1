using Tyuiu.KirichokEV.Sprint1.Task0.V8.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Киричлк Е. В.| РППб-24-1";
            //Длина строки 75 символов 
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                                  *");
            Console.WriteLine("* Задание #0                                                                        *");
            Console.WriteLine("* Вариант #8                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу которая вычисляет выражение 15 / 2 / 4                         *");
            Console.WriteLine("* и печатать результат на экране.                                                   *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* 15 / 2 / 4                                                                        *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.WriteLine();
        }
    }
}
