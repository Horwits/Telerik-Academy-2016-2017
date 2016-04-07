using System;

class Program
{
    static bool CheckAreTwoArraysEqual<T>(T[] firstArray, T[] secondArray)
        where T : IComparable
    {
        string firstArrayJoined = string.Join(" ", firstArray);
        string secondArrayJoined = string.Join(" ", secondArray);

        bool areEqual = firstArrayJoined == secondArrayJoined;
        return areEqual;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var firstArray = new int[n];
        var secondArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            firstArray[i] = number;
        }

        for (int i = 0; i < n; i++)
        {
            var number = int.Parse(Console.ReadLine());
            secondArray[i] = number;
        }

        Console.WriteLine(CheckAreTwoArraysEqual(firstArray, secondArray) ? "Equal" : "Not equal");
    }
}
