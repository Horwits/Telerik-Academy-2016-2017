using System;
using System.Linq;
using System.Text;

class TasksSolver
{
    static void GetChoice()
    {
        Console.WriteLine("For reversing the digits of a positive number, press 1: ");
        Console.WriteLine("For calculating the average of a sequence of integers, press 2: ");
        Console.WriteLine("For solving a linear equation a * x + b = 0, press 3: ");

        var choice = Console.ReadLine();

        if (choice[0] == '1')
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number));
        }
        else if (choice[0] == '2')
        {
            Console.WriteLine("Please enter some integer numbers splitted by single space.");
            var array = Console.ReadLine()
                .Split()
                .Select(z => Convert.ToInt32(z))
                .ToArray();

            double average = CalculateAverageOfSequence(array);
            Console.WriteLine(average);
        }
        else
        {
            Console.WriteLine("Please a and b, splitted by space.");
            var aAndB = Console.ReadLine().Split(' ');

            double a = double.Parse(aAndB[0]);
            double b = double.Parse(aAndB[1]);

            Console.WriteLine(SolveSimpleLinierEquation(a, b));
        }
    }

    static string ReverseString(StringBuilder input)
    {
        var reversed = new StringBuilder();

        int length = input.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }

    static string ReverseNumber(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number cannot be negative.");
        }

        var result = new StringBuilder();

        while (number != 0)
        {
            int digit = number % 10;
            result.Append(digit);

            number /= 10;
        }

        return ReverseString(result);
    }

    static double CalculateAverageOfSequence(params int[] array)
    {
        var result = 0d;

        var sum = result;
        var length = array.Length;

        foreach (var item in array)
        {
            sum += item;
        }

        result = sum / length;
        return result;
    }

    static double SolveSimpleLinierEquation(double a, double b)
    {
        double equation = b / a;
        return equation;
    }

    static void Main()
    {
        GetChoice();
    }
}
