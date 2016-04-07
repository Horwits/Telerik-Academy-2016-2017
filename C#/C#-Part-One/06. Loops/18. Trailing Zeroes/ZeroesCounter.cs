using System;
using System.Numerics;

class ZeroesCounter
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int divider = 5,
            trailingZeros = 0;
        while (divider <= number)
        {
            trailingZeros += number / divider;
            divider *= 5;
        }

        Console.WriteLine(trailingZeros);
    }
}

    //    string userInput = Console.ReadLine();

    //    int n;
    //    bool userInputIsValid = int.TryParse(userInput, out n);

    //    if (userInputIsValid)
    //    {
    //        BigInteger factorial = CalculateFactorial(n);

    //        long zeroesCount = CountTrailingZeros(factorial);
    //        Console.WriteLine("{0}", zeroesCount);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Invalid input!");
    //    }
    //}

    //private static long CountTrailingZeros(BigInteger factorial)
    //{
    //    long result = 0;

    //    string factorialToString = factorial.ToString();
    //    for (int i = factorialToString.Length - 1; i >= 0; i--)
    //    {
    //        if (factorialToString[i] == '0')
    //        {
    //            result++;
    //        }
    //        else
    //        {
    //            break;
    //        }
    //    }

    //    return result;
    //}

    //private static BigInteger CalculateFactorial(int n)
    //{
    //    BigInteger factorial = 1;
    //    for (int i = 1; i <= n; i++)
    //    {
    //        factorial *= i;
    //    }
    //    return factorial;
    //}
