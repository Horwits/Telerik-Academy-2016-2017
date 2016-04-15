using System;

class SumCalculator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        int factorial = 1;
        double pow = 1,
            sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            pow *= x;

            sum += factorial / pow;
        }

        Console.WriteLine("{0:F5}", sum);
    }
}
