using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static int[] GenerateSortedArray(int length)
    {
        int[] generatedArray = new int[length];

        for (int index = 0; index < length; index++)
        {
            generatedArray[index] = index + 1;
        }

        return generatedArray;
    }

    static int FindMiddleIndexBetweenAnotherTwo(int min, int max)
    {
        int mid = -1;

        if (min >= max)
        {
            return mid;
        }
        else
        {
            mid = (max / 2) + (min / 2);
        }

        return mid;
    }

    //itterative way
    static int BinarySearchAlgorithm(int[] array, int key, int min, int max)
    {
        while (max >= min)
        {
            int mid = FindMiddleIndexBetweenAnotherTwo(min, max);

            if (mid >= 0 && mid <= array.Length)
            {
                if (key > array[mid])
                {
                    min = mid + 1;
                }
                else if (key < array[mid] && mid >= 0 && mid <= array.Length)
                {
                    max = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            else
            {
                break;
            }
        }

        return -1;
    }

    //recursive way
    static int RecursiveBinarySearchAlgorithm(int[] array, int key, int min, int max)
    {
        var mid = FindMiddleIndexBetweenAnotherTwo(min, max);

        if (min >= max)
        {
            return -1;
        }

        if (key > array[mid])
        {
            return RecursiveBinarySearchAlgorithm(array, key, min + 1, max);
        }
        else if (key < array[mid])
        {
            return RecursiveBinarySearchAlgorithm(array, key, min, max - 1);
        }
        else
        {
            return mid;
        }
    }

    static void Main()
    {
        var numbers = GenerateSortedArray(2000);

        Console.WriteLine("Itterative");
        Console.WriteLine(BinarySearchAlgorithm(numbers, 15, 0, 10));

        Console.WriteLine("Recursive");
        Console.WriteLine(RecursiveBinarySearchAlgorithm(numbers, 15, 0, 16));
    }
}
