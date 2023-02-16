using System;

namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("C# Logical Programs");

            FibonacciSeries.Fibonacci();
            PerfectNumber.Perfect();
            PrimeNumber.Prime();
            ReverseNumber.Reverse();
            DayOfWeek.Week();
            TempConversion.Conversion();
            MonthlyPayment.Payment();

            Console.ReadLine();
        }
    }
}
