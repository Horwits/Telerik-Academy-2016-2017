using System;

class SquareRoot
{
    static void Main()
    {
        /*Create a console application that calculates and prints the square root of the number 12345.
        Find in Internet “how to calculate square root in C#”.*/

        int number = 12345;
        /*string message = "Please add a number: ";
        Console.WriteLine(message);

        var input = Console.ReadLine();
        var isNumber = int.TryParse(input, out number);*/

        var result = Math.Sqrt(number);
        Console.WriteLine(result);
    }
}
