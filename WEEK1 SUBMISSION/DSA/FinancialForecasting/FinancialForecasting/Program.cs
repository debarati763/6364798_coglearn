
using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal = 10000;  
            double rate = 0.05;         
            int years = 5;

            double futureValue = Forecasting.CalculateFutureValue(principal, rate, years);
            Console.WriteLine($"Future value after {years} years: ₹{futureValue:F2}");

            Console.ReadLine();
        }
    }
}

