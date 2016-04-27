using System;

class Program
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        short s = short.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double neededPaper = n * s;
        double price = (neededPaper / 400) * p;

        Console.WriteLine("{0:f3}", price);
    }
}
