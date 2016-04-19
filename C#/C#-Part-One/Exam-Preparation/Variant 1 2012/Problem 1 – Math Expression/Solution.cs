using System;

class Solution
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        int inSinExpr = (int)(m % 180);

        double result = (((n * n) + (1 / (m * p)) + 1337) / (n - 128.523123123 * p)) + Math.Sin(inSinExpr);

        Console.WriteLine("{0:f6}", result);
    }
}
