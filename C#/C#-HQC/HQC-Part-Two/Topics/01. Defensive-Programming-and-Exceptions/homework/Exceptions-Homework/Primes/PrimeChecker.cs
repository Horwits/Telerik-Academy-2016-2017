using System;

public class PrimeChecker
{
    public static bool CheckIfPrime(int number)
    {
        var isBiggerThanMaxInt = number >= int.MaxValue;
        if (isBiggerThanMaxInt)
        {
            throw new ArgumentOutOfRangeException("number", "number is bigger than int.Maxvalue.");
        }

        var isNumberSmallerThanDivisor = number < 2;
        if (isNumberSmallerThanDivisor)
        {
            throw new ArgumentOutOfRangeException("number", "number is smaller than divisor = 2.");
        }

        var isPrime = true;
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
            }
        }

        return isPrime;
    }
}