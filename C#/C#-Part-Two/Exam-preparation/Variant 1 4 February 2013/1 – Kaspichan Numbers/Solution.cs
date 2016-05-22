using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class Solution
{
    static string ConvertDecimalToHex(BigInteger decValue, List<string> numbers)
    {
        // better performance could be achieved by using indexing instead of concatanation
        string result = string.Empty;

        do
        {
            int value = (int)(decValue % 256);
            result = numbers[value] + result;
            decValue /= 256;

        } while (decValue != 0);

        return result;
    }

    static string ExcelColumnIndexToName(int Index)
    {
        string range = string.Empty;
        if (Index < 0) return range;
        int a = 26;
        int x = (int)Math.Floor(Math.Log((Index) * (a - 1) / a + 1, a));
        Index -= (int)(Math.Pow(a, x) - 1) * a / (a - 1);
        for (int i = x + 1; Index + i > 0; i--)
        {
            range = ((char)(65 + Index % a)).ToString() + range;
            Index /= a;
        }
        return range;
    }

    static List<string> GenerateNumbers()
    {
        var numbers = new List<string>(256);
        var currentNumber = new StringBuilder();
        for (int i = 0; i < 256; i++)
        {
            if (i >= 26)
            {
                currentNumber.Append(ExcelColumnIndexToName(i));
                char toBeReplaced = currentNumber[0];
                currentNumber.Replace(toBeReplaced, char.ToLower(toBeReplaced), 0, 1);
                numbers.Add(currentNumber.ToString());

                currentNumber.Clear();
            }
            else
            {
                numbers.Add(ExcelColumnIndexToName(i));
            }
        }

        return numbers;
    }

    static void Main(string[] args)
    {
        var numbers = GenerateNumbers();
        var number = BigInteger.Parse(Console.ReadLine());

        var result = ConvertDecimalToHex(number, numbers);
        Console.WriteLine(result);
    }
}
