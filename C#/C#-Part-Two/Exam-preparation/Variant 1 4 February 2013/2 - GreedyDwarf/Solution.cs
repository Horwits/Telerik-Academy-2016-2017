using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int[] valley;
    static int m;
    static int[][] currentPatterns;
    static List<int> coins = new List<int>();

    static void ReadInput()
    {
        valley = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

        m = int.Parse(Console.ReadLine());

        currentPatterns = new int[m][];
        for (int i = 0; i < m; i++)
        {
            var currentP =
                Console.ReadLine()
                   .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Where(x => x != "-")
                   .Select(x => int.Parse(x))
                   .ToArray();

            currentPatterns[i] = currentP;
        }
    }

    static void Patterns(int[] currentPattern)
    {
        bool[] visited = new bool[valley.Length];

        var currentPosition = 0L;
        var previousPosition = currentPosition;

        var currentCollectedCoins = valley[currentPosition];
        currentPosition += currentPattern[currentPosition];

        visited[previousPosition] = true;

        var length = valley.Length;
        int i = 1;
        if (i < currentPattern.Length)
        {
            while (true)
            {
                previousPosition = currentPosition;

                if (currentPosition < length && currentPosition >= 0 && visited[currentPosition] == false)
                {
                    currentCollectedCoins += valley[currentPosition];

                    currentPosition += currentPattern[i];

                    visited[previousPosition] = true;
                }
                else
                {
                    break;
                }

                if (i == currentPattern.Length - 1)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
        }

        CollectCurrentCoinsReasult(currentCollectedCoins);
    }

    static void CollectCurrentCoinsReasult(int currentCoinsReasult)
    {
        coins.Add(currentCoinsReasult);
    }

    static int FindMaxCoinsResult()
    {
        var max = coins[0];

        for (int i = 1; i < coins.Count; i++)
        {
            max = Math.Max(max, coins[i]);
        }

        return max;
    }

    static void PrintBestRouteResult(int max)
    {
        Console.WriteLine(max);
    }

    static void Main(string[] args)
    {
        //input
        ReadInput();

        //solution
        for (int i = 0; i < currentPatterns.Length; i++)
        {
            Patterns(currentPatterns[i]);
        }

        //output
        var maxRouteResult = FindMaxCoinsResult();
        PrintBestRouteResult(maxRouteResult);
    }
}
