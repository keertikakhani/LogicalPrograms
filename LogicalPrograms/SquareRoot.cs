using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class SquareRoot
    {
        public static void Sqrt()
        {
            Console.WriteLine("Enter the Number");
            double c = Convert.ToDouble(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;
            while (Math.Abs(t - (c / t)) > epsilon * t)
            {
                t = ((c / t + t) / 2);
            }

            Console.WriteLine("square root is : " + t);

        }
    }
}
