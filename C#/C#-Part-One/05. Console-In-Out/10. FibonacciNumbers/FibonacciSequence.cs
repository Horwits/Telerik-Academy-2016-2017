using System;
using System.Numerics;

class FibonacciSequence
{
    public static decimal Fibonacci(int n)
    {
        decimal a = 0;
        decimal b = 1;
        // In N steps compute Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {
            decimal temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        int length = int.Parse(Console.ReadLine());



        for (int i = 0; i < length; i++)
        {
            if (i < length - 1)
            {
                Console.Write("{0}, ",Fibonacci(i));
            }
            else
            {
                Console.Write("{0}", Fibonacci(i));
            }
        }

        Console.WriteLine();
    }
}

