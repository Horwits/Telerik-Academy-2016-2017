using System;
using System.Text;

class StringReverser
{
    static string ReverseString(string input)
    {
        var reversed = new StringBuilder();

        int length = input.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }

    static void Main()
    {
        var input = Console.ReadLine();
        Console.WriteLine(ReverseString(input));
    }
}
