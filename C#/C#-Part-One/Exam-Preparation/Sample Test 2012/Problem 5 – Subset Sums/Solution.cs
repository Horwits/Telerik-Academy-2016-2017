using System;

class SubsetSums
{
    static void Main(string[] args)
    {
        long s = long.Parse(Console.ReadLine());
        int n = Int32.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        int[] currentCombination = new int[n];
        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            GenerateCombinationsRecursively(ref numbers, i, 0, -1, ref currentCombination, s, ref result);
        }
        Console.WriteLine(result);
    }

    static void GenerateCombinationsRecursively(ref long[] elements, int klass, int currentPosition, int numberOnPrevPosition, ref int[] currentCombination, long sum, ref int result)
    {
        int n = elements.Length;
        for (int u = numberOnPrevPosition + 1; u < n; u++)
        {
            currentCombination[currentPosition] = u;
            if (currentPosition == klass - 1)
            {
                CalculateCombinationSum(klass, ref elements, ref currentCombination, ref result, ref sum);
            }
            else
            {
                GenerateCombinationsRecursively(ref elements, klass, currentPosition + 1, u, ref currentCombination, sum, ref result);
            }
        }
    }

    static void CalculateCombinationSum(int klass, ref long[] elements, ref int[] currentCombination, ref int result, ref long sum)
    {
        long currentSum = 0;
        for (int u = 0; u < klass; u++)
        {
            int currentIndex = currentCombination[u];
            currentSum += elements[currentIndex];
        }
        if (currentSum == sum)
        {
            result++;
        }
    }
}