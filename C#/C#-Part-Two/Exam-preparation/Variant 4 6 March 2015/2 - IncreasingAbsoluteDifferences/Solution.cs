using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var currentSequence =
                Console.ReadLine()
                    .Split(' ')
                    .Select(x => long.Parse(x))
                    .ToArray();

            var differenceSequence = new List<long>();

            for (int k = 1; k < currentSequence.Length; k++)
            {
                long absolute = Math.Abs(currentSequence[k] - currentSequence[k - 1]);
                differenceSequence.Add(absolute);
            }

            var isIncreasing = false;
            if (differenceSequence.Count == 1)
            {
                isIncreasing = true;
            }
            else
            {
                for (int j = 1; j < differenceSequence.Count(); j++)
                {
                    long difference = differenceSequence[j] - differenceSequence[j - 1];
                    if (difference == 1 || difference == 0)
                    {
                        isIncreasing = true;
                        continue;
                    }
                    else
                    {
                        isIncreasing = false;
                        break;
                    }
                }
            }

            if (isIncreasing)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
