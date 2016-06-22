namespace CovergentSeries
{
    using System;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            var result = Calculator.Calculate(x => x / 2, 100);
            Console.WriteLine("{0:f2}", result);

            result = Calculator.Calculate(x => -x / 2, 100);
            Console.WriteLine("{0:f2}", result);

            result = Calculator.Calculate((x, i) => x * (1 / i), 100);
            Console.WriteLine("{0:f2}", result);
        }
    }
}
