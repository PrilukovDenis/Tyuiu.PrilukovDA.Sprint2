using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PrilukovDA.Sprint2.Task2.V1.Lib
{
    public class DataService : ISprint2Task2V1
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            {
                if (x < 1 || x > 15 || y < 1 || y > 15)
                    return false;

                switch (y)
                {
                    case 3:
                        return (x >= 3 && x <= 5) || x == 9 || x == 12;
                    case 4: 
                        return (x >= 3 && x <= 5) || x == 9 || x == 12;
                    case 5:
                        return (x >= 5 && x <= 12);
                    case 6:
                        return (x >= 5 && x <= 13);
                    case 7:
                        return (x >= 3 && x <= 13);
                    case 8:
                        return (x >= 6 && x <= 8) || (x >= 12 && x <= 13);
                    case 9:
                        return (x >= 6 && x <= 8) || (x == 12);
                    case 10:
                        return (x >= 6 && x <= 8) || (x == 12);
                    case 11:
                        return (x >= 3 && x <= 8) || (x == 12);
                    case 12:
                        return x == 4 || (x >= 7 && x <= 8);
                    case 13:
                        return x == 4;
                    default: 
                        return false;
                }
            }
            ;
        }
    }
}
