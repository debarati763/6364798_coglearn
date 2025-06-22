using System;

namespace FinancialForecasting
{
    public class Forecasting
    {
        public static double CalculateFutureValue(double principal, double rate, int years)
        {
            
            if (years == 0)
                return principal;

            
            return CalculateFutureValue(principal, rate, years - 1) * (1 + rate);
        }
    }
}
