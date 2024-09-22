using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MiliukovLO.Sprint1.Task4.V9.Lib
{
    public class DataService : ISprint1Task4V9
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Log(x*y)/(x-(1+Math.Sqrt(y*y))), 3);
        }
    }
}
