using Tyuiu.KirichokEV.Sprint1.Task5.V3.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task5.V3
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
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #3                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                              *");
            Console.WriteLine("* присвоить целой перменной h третью от конца цифру в записи положительного         *");
            Console.WriteLine("* целого числа k                                                                    *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int k;

            Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ k:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            int res = Convert.ToInt32(ds.Calculate(k));
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
