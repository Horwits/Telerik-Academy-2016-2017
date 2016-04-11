using System;
using System.Numerics;

class FactorialCalculator
{
    static BigInteger CalculateFactorial(int number)
    {
        if (number < 0 && number < 101)
        {
            throw new ArgumentException("Argument has to be bigger than 0.");
        }

        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static void Main()
    {
        try
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(n));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
