using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        var rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            var currentNumbers = Console.ReadLine()
                                            .Split(' ')
                                            .Select(x => int.Parse(x))
                                            .ToArray();

            int length = currentNumbers.Length;
            bool isDecreasing = false;

            var currentDifferences = new List<int>();
            for (int index = 1; index < length; index++)
            {
                var a = currentNumbers[index];
                var b = currentNumbers[index - 1];
                var absoluteDifference = Math.Abs(a - b);

                currentDifferences.Add(absoluteDifference);
            }

            if (currentDifferences.Count < 2)
            {
                isDecreasing = true;
            }
            else
            {
                for (int index = 1; index < currentDifferences.Count; index++)
                {
                    var a = currentDifferences[index - 1];
                    var b = currentDifferences[index];

                    if (a >= b && a - b == 1 || a - b == 0)
                    {
                        isDecreasing = true;
                    }
                    else
                    {
                        isDecreasing = false;
                        break;
                    }
                }
            }

            if (isDecreasing)
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
