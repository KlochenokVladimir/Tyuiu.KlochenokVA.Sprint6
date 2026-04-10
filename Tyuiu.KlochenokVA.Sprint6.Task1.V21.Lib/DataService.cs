using tyuiu.cources.programming.interfaces.Sprint6;
using System;

namespace Tyuiu.KlochenokVA.Sprint6.Task1.V21.Lib
{
    public class DataService : ISprint6Task1V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) +1;
            double[] array = new double[len];
            int count =0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom =2 - 6 * x;
                if (Math.Abs(denom) < Double.Epsilon)
                {
                    array[count] =0; // защита от деления на ноль
                }
                else
                {
                    // F(x) = cos(x) + sin(x)/(2 -6x) -4x
                    array[count] = Math.Round(Math.Cos(x) + Math.Sin(x) / denom - 4 * x,2);
                }
                count++;
            }
            return array;
        }
    }
}
