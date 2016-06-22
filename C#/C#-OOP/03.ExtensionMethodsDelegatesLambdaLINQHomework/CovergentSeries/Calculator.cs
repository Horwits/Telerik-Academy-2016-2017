namespace CovergentSeries
{
    using System;

    public static class Calculator
    {
        public static double Calculate(Func<double, double> func, int loops)
        {
            double last = 1;
            double sum = 0;
            for (int i = 1; i < loops; i++)
            {
                sum += last;
                last = func(last);
            }

            return sum;
        }

        public static double Calculate(Func<double, double, double> func, int loops)
        {
            double last = 1;
            double sum = 0;
            for (int i = 1; i < loops + 1; i++)
            {
                last = func(last, i);
                sum += last;
            }

            return sum;
        }
    }
}
