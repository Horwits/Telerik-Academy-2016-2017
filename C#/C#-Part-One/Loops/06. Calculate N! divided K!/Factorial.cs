using System;

class Factorial
{
    static void Main()
    {
        /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
        Use only one loop.
        
        n	k	n! / k!
        5	2	60
        6	5	6
        8	3	6720
        */

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        decimal factorialN = 1,
            factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                factorialK *= i;
            }

            factorialN *= i;
        }

        decimal result = factorialN / factorialK;
        Console.WriteLine("{0}", result);
    }
}
