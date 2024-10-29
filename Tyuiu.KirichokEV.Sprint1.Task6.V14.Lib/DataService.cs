using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KirichokEV.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {

            int Ru = 0, En = 0;
            string line = value;
            line = line.ToUpper();
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if ((c >= 'А') && (c <= 'Я'))
                    Ru++;
                else if ((c >= 'A') && (c <= 'Z')) En++;
            }
            if (Ru > 0 && En == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
