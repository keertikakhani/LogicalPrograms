using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine("enter the number to print fibonacci series");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Series");
            Console.Write("{0} {1}", num1, num2);

            for (int i = 2; i < number; i++)
            {
                num3 = num1 + num2;
                Console.Write(" {0} ", num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
