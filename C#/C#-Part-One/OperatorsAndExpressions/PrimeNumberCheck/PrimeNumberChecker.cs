using System;

class PrimeNumberChecker
{
    static void Main()
    {
        /*Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).*/

        string input = Console.ReadLine();

        byte number;
        bool inputIsValid = byte.TryParse(input, out number);

        if (inputIsValid)
        {
            bool numberIsPrime = isPrime(number);

            Console.WriteLine("{0}", numberIsPrime ? "true" : "false");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    public static bool isPrime(int number)
    {
        double boundary = Math.Sqrt(number);

        if ((number == 0) || (number == 1)) return false;

        if (number == 2) return true;

        for (int i = 2; i <= boundary; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
