using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        var length = numbers.Length;
        var resultedNumbers = new List<int>();
        for (int i = 1; i < length; i++)
        {
            var absolute = Math.Abs(numbers[i] - numbers[i - 1]);
            i += absolute % 2 == 0 ? 1 : 0;

            if (absolute % 2 == 0)
            {
                resultedNumbers.Add(absolute);
            }
        }

        BigInteger result = resultedNumbers.Sum();
        Console.WriteLine(result);
    }
}