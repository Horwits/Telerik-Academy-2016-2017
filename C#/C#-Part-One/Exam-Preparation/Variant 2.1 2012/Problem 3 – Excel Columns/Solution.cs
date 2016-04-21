using System;
using System.Text;

class Solution
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        var input = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            input.Append(Console.ReadLine());
        }

        decimal sum = 0;
        for (int i = 0; i < length; i++)
        {
            sum *= 26;
            sum += (input[i] - 'A' + 1);
        }

        Console.WriteLine(sum);
    }
}
