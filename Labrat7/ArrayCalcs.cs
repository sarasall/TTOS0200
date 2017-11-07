using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class ArrayCalcs
    {
        public ArrayCalcs () { }

        public static double Sum (double [] array)
        {
            return array.Sum();
        }
        public static double Average(double[] array)
        {
            return array.Average();
        }
        public static double Min(double[] array)
        {
            return array.Min();
        }
        public static double Max(double[] array)
        {                 
            return array.Max();
        }
    }
    public class TestArrayClass
    {
        public static void Test()
        {
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };

                Console.WriteLine(String.Format("{0:Sum: 0.00}", ArrayCalcs.Sum(array)));
                Console.WriteLine(String.Format("{0:Average: 0.00}", ArrayCalcs.Average(array)));
                Console.WriteLine(String.Format("Min: " + "{0:0.00}", ArrayCalcs.Min(array)));
                Console.WriteLine(String.Format("{0:Max: 0.00}", ArrayCalcs.Max(array)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
