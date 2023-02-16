using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void Prime()
        {
            int count = 0;
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    count = count + 1;
                }

            }
            if (count > 2)
                Console.WriteLine("{0} is not prime number", number);
            else
                Console.WriteLine("{0} is prime number", number);
        }
    }
}
