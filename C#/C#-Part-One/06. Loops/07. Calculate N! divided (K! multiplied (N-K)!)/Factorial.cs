using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        /*In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
        Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
        
        n	k	n! / (k! * (n-k)!)
        3	2	3
        4	2	6
        10	6	210
        52	5	2598960
        
        */

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nMinusK = n - k;

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nMinusKFactorial = 1;

        if (1 <= k && k < n && n <= 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;

                if (i <= nMinusK)
                {
                    nMinusKFactorial *= i;
                }

                //with one loop
                /*if (i <= k)
                {
                    kFactorial *= i;
                }*/
            }

            for (int j = 1; j <= k; j++)
            {
                kFactorial *= j;
            }

            BigInteger result = nFactorial / (kFactorial * nMinusKFactorial);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
