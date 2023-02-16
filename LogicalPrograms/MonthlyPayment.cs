using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public static void Payment()
        {
            Console.WriteLine("Enter the Principal loan amount");
            double P = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the year");
            double Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Rate of Interest");
            double R = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("MonthlyPayment is : " + payment);
        }
    }
}
