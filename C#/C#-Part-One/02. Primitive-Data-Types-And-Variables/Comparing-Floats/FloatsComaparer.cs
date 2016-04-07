using System;

class FloatsComaparer
{
    static void Main()
    {
        /*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());

        double difference = (Math.Max(a, b) - Math.Min(a, b));
        double eps = 0.000001;

        bool areEqual = difference < eps;

        Console.WriteLine(areEqual.ToString().ToLower());

    }
}
