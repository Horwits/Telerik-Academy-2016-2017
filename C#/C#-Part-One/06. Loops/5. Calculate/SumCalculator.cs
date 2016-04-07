using System;

class SumCalculator
{
    static void Main()
    {
        /*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
        Use only one loop. Print the result with 5 digits after the decimal point.*/

        //int n = 4;
        //int x = 3;

        //int n = 3;
        //int x = 2;

        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1;
        decimal factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;

            decimal pow = (decimal)(Math.Pow(x, i));
            sum += (factorial / pow);
        }

        Console.WriteLine("{0:f5}", sum);
    }
}
