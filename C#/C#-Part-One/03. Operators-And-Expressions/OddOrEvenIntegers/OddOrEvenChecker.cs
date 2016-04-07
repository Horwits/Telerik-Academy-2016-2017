using System;

class OddOrEvenChecker
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        bool isEven = number % 2 == 0;

        if (isEven)
        {
            Console.WriteLine("even {0}", number);
        }
        else
        {
            Console.WriteLine("odd {0}", number);
        }
    }
}
