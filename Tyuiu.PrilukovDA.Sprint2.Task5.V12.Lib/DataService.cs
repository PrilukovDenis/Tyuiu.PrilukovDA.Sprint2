using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PrilukovDA.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                return $"{n - 1}.{m}.{g}";
            }
            int prevMonth, prevDay;

            if (m == 1)
            {
                prevMonth = 12;
                prevDay = 31;
                g--;
            }
            else
            {
                prevMonth = m - 1;
                switch (prevMonth)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        prevDay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        prevDay = 30;
                        break;
                    case 2:
                        prevDay = 29;
                        break;
                    default:
                        prevDay = 31;
                        break;
                }
            }

            return $"{prevDay}.{prevMonth}.{g}";
        }
    }
}
