using System;

class IntegerSumator
{
    public static int SumValuesOfString(string numbers)
    {
        var splitted = numbers.Split(' ');

        int sum = 0;
        foreach (var number in splitted)
        {
            sum += int.Parse(number);
        }

        return sum;
    }

    static void Main()
    {
        string input = "43 68 9 23 318";

        Console.WriteLine(SumValuesOfString(input));
    }
}
