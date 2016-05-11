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
        string input = Console.ReadLine();

        Console.WriteLine(SumValuesOfString(input));
    }
}
