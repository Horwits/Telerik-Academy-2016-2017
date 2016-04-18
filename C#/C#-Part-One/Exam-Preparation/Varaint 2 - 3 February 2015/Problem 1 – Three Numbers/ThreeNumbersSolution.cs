using System;

class ThreeNumbersSolution
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double max = Math.Max(Math.Max(a, b), c);
        double min = Math.Min(Math.Min(a, b), c);

        double sum = a + b + c;
        double arithmeticMean = sum / 3.00;

        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine("{0:f2}", arithmeticMean);
    }
}
