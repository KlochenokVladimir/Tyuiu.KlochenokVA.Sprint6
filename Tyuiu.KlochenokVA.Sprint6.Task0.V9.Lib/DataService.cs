using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KlochenokVA.Sprint6.Task0.V9.Lib
{
    public class DataService : ISprint6Task0V9
    {
        public double Calculate(int x)
        {
            double res = (4d - (double)(x * x * x)) / (double)(x * x);
            return Math.Round(res, 3);
        }
    }
}
