using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    private static List<int> GetAllPrimesLessThan(int maxPrime)
    {
        var primes = new List<int>() { 2 };
        var maxSquareRoot = Math.Sqrt(maxPrime);
        var eliminated = new BitArray(maxPrime + 1);

        for (int i = 3; i <= maxPrime; i += 2)
        {
            if (!eliminated[i])
            {
                primes.Add(i);
                if (i < maxSquareRoot)
                {
                    for (int j = i * i; j <= maxPrime; j += 2 * i)
                    {
                        eliminated[j] = true;
                    }
                }
            }
        }

        return primes;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = GetAllPrimesLessThan(n);

        int lastPosition = numbers.Count - 1;
        Console.WriteLine(numbers[lastPosition]);
    }
}
