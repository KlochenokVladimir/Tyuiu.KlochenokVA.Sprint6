using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KlochenokVA.Sprint6.Task2.V27.Lib
{
    public class DataService : ISprint6Task2V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            if (len <= 0) return Array.Empty<double>();
            double[] array = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double cosx = Math.Cos(x);
                if (Math.Abs(cosx) < 1e-12)
                {
                    array[count] = 0; // avoid division by zero
                }
                else
                {
                    double value = 5.0 * x - 3.0 / cosx - Math.Sin(x);
                    array[count] = Math.Round(value, 2);
                }
                count++;
            }

            return array;
        }
    }
}
