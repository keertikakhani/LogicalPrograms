using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TempConversion
    {
        public static void Conversion()
        {
            Console.WriteLine("Enter the Temperature in celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Degree fahrenheit is : " + fahrenheit);

            Console.WriteLine("Enter the Temperature in fahrenheit");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Degree celsius is : " + celsius);
        }
    }
}
