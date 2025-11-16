using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PrilukovDA.Sprint2.Task3.V10.Lib
{
    public class DataService : ISprint2Task3V10
    {
        public double Calculate(double x)
        {
            double result;
            if (x > 0)
            {
                result = x - Math.Pow((x + 15) / (x - 4), x);
            }
            else if (x == 0)
            {
                double x2 = x * x;
                result = (x2 + Math.Cos(x2) - 3) / (x2 - Math.Sin(x2) + 2);
            }
            else if (x > -14)
            {
                result = Math.Pow(5 + 1.0 / (x * x), x);
            }
            else
            {
                result = x + 10 * x - 1.0 / x;
            }
            return Math.Round(result, 3);
        }
    }
}
