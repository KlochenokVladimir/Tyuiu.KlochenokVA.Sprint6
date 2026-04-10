using System;

namespace Tyuiu.KlochenokVA.Sprint6.Task2.V27
{
 // Local copy of DataService to avoid project reference issues for the Form project.
 public class DataService
 {
 public double[] GetMassFunction(int startValue, int stopValue)
 {
 int len = (stopValue - startValue) +1;
 if (len <=0) return Array.Empty<double>();
 double[] array = new double[len];
 int count =0;

 for (int x = startValue; x <= stopValue; x++)
 {
 double denom =2.0 -2.0 * x;
 if (Math.Abs(denom) <1e-12)
 {
 array[count] =0;
 }
 else
 {
 array[count] = Math.Round(Math.Cos(x) + Math.Sin(x) / denom -4 * x,2);
 }
 count++;
 }

 return array;
 }
 }
}
