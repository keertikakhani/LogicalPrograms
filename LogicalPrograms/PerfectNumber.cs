using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    { 
            public static void Perfect()
            {
                int sum = 0;
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum = sum + i;
                    }
                }

                if (sum == number)
                {
                    Console.WriteLine("{0} is perfect number", number);
                }
                else
                {
                    Console.WriteLine("{0} is not perfect number", number);
                }
            }
    }
}

