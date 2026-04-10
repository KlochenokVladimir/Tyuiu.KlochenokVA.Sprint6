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
                double denom = 2.0 - 2.0 * x;
                if (Math.Abs(denom) < 1e-12)
                {
                    array[count] = 0;
                }
                else
                {
                    array[count] = Math.Round(Math.Cos(x) + Math.Sin(x) / denom - 4 * x, 2);
                }
                count++;
            }

            return array;
        }
    }
}
