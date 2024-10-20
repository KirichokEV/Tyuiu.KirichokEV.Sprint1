using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KirichokEV.Sprint1.Task4.V8.Lib
{
    public class DataService : ISprint1Task4V8
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Sqrt(Math.Abs(x - y)) + (3 * x)) / (3 + Math.Abs(x));
            return Math.Round(res, 3);
        }
    }
}
