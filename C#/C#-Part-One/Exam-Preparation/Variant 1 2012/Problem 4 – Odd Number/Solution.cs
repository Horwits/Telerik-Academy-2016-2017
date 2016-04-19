using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        long result = 0;

        var groups = numbers.GroupBy(item => item);
        foreach (var group in groups)
        {
            int count = group.Count();
            if (count % 2 == 1)
            {
                result = group.Key;
            }
        }

        Console.WriteLine(result);
    }
}
