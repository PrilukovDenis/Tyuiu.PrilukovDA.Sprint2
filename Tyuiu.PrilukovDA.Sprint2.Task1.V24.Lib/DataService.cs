using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PrilukovDA.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return new bool[] {
                (a == b) & (c < d),
                (a != b) | (c > d),
                (a == b) && (c <= d),
                (a != b) || (c >= d),
                !(a > b) ^ (c == d),
                (a < b) & !(c != d)
            };
        }
    }
}
