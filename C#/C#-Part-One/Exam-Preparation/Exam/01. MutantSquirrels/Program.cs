using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        double trees = double.Parse(Console.ReadLine());
        double branches = double.Parse(Console.ReadLine());
        double numberOfSqOnBranch = double.Parse(Console.ReadLine());
        double averageTails = double.Parse(Console.ReadLine());

        double tails = (trees * branches * numberOfSqOnBranch * averageTails);

        if ((long)tails % 2 == 0)
        {
            tails *= 376439;
            Console.WriteLine("{0:f3}", tails);

        }
        else
        {
            double result = (tails /= 7);
            Console.WriteLine("{0:f3}", result);
        }
    }
}
