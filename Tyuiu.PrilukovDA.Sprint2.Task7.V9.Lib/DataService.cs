using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PrilukovDA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double SinX = Math.Sin(x);
            return (SinX >= 0.5) && (y >= 0.5) && (y <= SinX);
        }
    }
}
