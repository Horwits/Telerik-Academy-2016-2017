using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        /*In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
        Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
        Examples:
        
        n	Catalan(n)
        0	1
        5	42
        10	16796
        15	9694845*/

        string userInput = Console.ReadLine();

        int n;
        bool userInputIsValid = int.TryParse(userInput, out n);
        if (userInputIsValid)
        {
            bool rangeIsCorrect = 0 <= n && n <= 100;
            if (rangeIsCorrect)
            {
                BigInteger nFactorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    nFactorial *= i;
                }

                int nPlusOne = n + 1;
                BigInteger nPlusOneFactorial = 1;
                for (int i = 1; i <= nPlusOne; i++)
                {
                    nPlusOneFactorial *= i;
                }

                BigInteger factorialTwoTimesN = 1;
                int twoTimesN = 2 * n;
                for (int i = 1; i <= twoTimesN; i++)
                {
                    factorialTwoTimesN *= i;
                }

                BigInteger result = factorialTwoTimesN / (nPlusOneFactorial * nFactorial);
                Console.WriteLine("{0}", result);
            }
            else
            {
                Console.WriteLine("Your number has to be in the Range (0 ≤ n ≤ 100)!");
            }
        }
        else
        {
            Console.WriteLine("Ivalid input");
        }
    }
}
