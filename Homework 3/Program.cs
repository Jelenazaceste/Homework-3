using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] decimals =
                {
                Decimal.MaxValue,20.1M, 0M, -20.1M, decimal.MinValue };
            Console.WriteLine("Absolute value of decimals:");
            foreach (decimal value in decimals)
                Console.WriteLine($"Abs({value})={Math.Abs(value)}");
            Console.WriteLine("\n");
            Console.ReadKey();

            double[] doubles =
            {
                Double.MaxValue, -1.79d,0d, 1.5d, double.MinValue };
            Console.WriteLine("Absolute value of a number of doubles:");
            foreach (double value in doubles)
                Console.WriteLine($"Abs({value})={Math.Abs(value)}");
            Console.WriteLine("\n");
            Console.ReadKey();

            short[] values1 =
            {
                Int16.MaxValue, 1500, 0, -1467, Int16.MinValue };
            Console.WriteLine("Absolute value of a number of short 16 int:");
            foreach (short value in values1)
            {

                try
                {
                    Console.WriteLine($"Abs({value})={Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate absolute  value of {0}", value);
                }
                Console.WriteLine("\n");
                Console.ReadKey();

            }

            int[] values2 =
            {
                Int32.MaxValue, 156789, 0, -1456789, Int32.MinValue };
            Console.WriteLine("Absolute value of number of ints 32 values: ");
            foreach (int value2 in values2)
            {
                try
                {
                    Console.WriteLine($"Abs({value2})={Math.Abs(value2)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate absolute value of {0}", value2);
                }
                Console.WriteLine("\n");
                Console.ReadKey();

            }

            long[] value3 = {
            Int64.MaxValue, 10013l, 0l, -6871982l, Int64.MaxValue };
            Console.WriteLine("Absolute value of number of ints 64 values: ");
            foreach (long value in value3)
            {
                try
                {
                    Console.WriteLine($"Abs({value})={Math.Abs(value)}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unable to calculate absolute value of {0}", value);
                }
                Console.WriteLine("\n");
                Console.ReadKey();




            }
        }
}   }
