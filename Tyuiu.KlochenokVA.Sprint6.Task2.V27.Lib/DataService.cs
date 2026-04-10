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
                double y = Math.Round(((2.0 * x - 3.0) / (Math.Cos(x) - 2.0 * x) + 5.0 * x - Math.Sin(x)), 2);
                array[count] = y;
                count++;
            }

            return array;
        }
    }
}
