using System;
using System.Collections.Generic;

class MergeSort
{
    static List<T> MergeSortAlgorithm<T>(List<T> elements)
        where T : IComparable<T>
    {
        //find where is the bottom of the recursion
        if (elements.Count <= 1)
        {
            return elements;
        }

        //split the elements array by two equal length arrays
        var leftLength = elements.Count / 2;

        //this can be acieved with addRange
        var left = new List<T>();
        for (int i = 0; i < leftLength; i++)
        {
            left.Add(elements[i]);
        }

        var right = new List<T>();
        for (int i = leftLength; i < elements.Count; i++)
        {
            right.Add(elements[i]);
        }

        left = MergeSortAlgorithm(left);
        right = MergeSortAlgorithm(right);

        return Merge(left, right);
    }

    static List<T> Merge<T>(List<T> left, List<T> right)
        where T : IComparable<T>
    {
        //compare left first element with right first element
        //if left element is bigger rigth is going at pos prevpos -> in new merge array that has special indexator
        //if el from left == el from rigth -> left is first  

        var merged = new List<T>();

        int leftIndex = 0;
        int rightIndex = 0;
        while (leftIndex < left.Count && rightIndex < right.Count)
        {
            if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
            {
                merged.Add(left[leftIndex]);
                leftIndex++;
            }
            else if (left[leftIndex].CompareTo(right[rightIndex]) > 0)
            {
                merged.Add(right[rightIndex]);
                rightIndex++;
            }
            else
            {
                merged.Add(left[leftIndex]);
                leftIndex++;
            }
        }

        if (rightIndex < right.Count)
        {
            for (int i = rightIndex; i < right.Count; i++)
            {
                merged.Add(right[i]);
            }
        }
        else if (leftIndex < left.Count)
        {
            for (int i = leftIndex; i < left.Count; i++)
            {
                merged.Add(left[i]);
            }
        }

        return merged;
    }

    static void Main(string[] args)
    {
        var numbers = new List<int>() { 12, 34, 1, 4, 200, 14 };

        var letters = new List<char>() { 'a', 'z', 'j', 'y', 'b', 'c' };

        Console.WriteLine(string.Join(" ", MergeSortAlgorithm(numbers)));

        Console.WriteLine(string.Join(" ", MergeSortAlgorithm(letters)));
    }
}
