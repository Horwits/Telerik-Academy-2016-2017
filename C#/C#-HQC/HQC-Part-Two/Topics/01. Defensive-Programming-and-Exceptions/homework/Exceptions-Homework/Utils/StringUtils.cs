using System;
using System.Collections.Generic;
using System.Text;

public static class StringUtils
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        var isCountValid = startIndex < arr.Length && startIndex >= 0;
        if (!isCountValid)
        {
            throw new ArgumentOutOfRangeException("count", "Invalid count!");
        }

        var result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractTextEnding(string text, int count)
    {
        var isCountValid = count < text.Length;
        if (!isCountValid)
        {
            throw new ArgumentOutOfRangeException("count", "Invalid count!");
        }

        var result = new StringBuilder();
        for (int i = text.Length - count; i < text.Length; i++)
        {
            result.Append(text[i]);
        }

        return result.ToString();
    }
}
