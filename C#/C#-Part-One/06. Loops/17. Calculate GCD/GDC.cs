using System;

class GDC
{
    //static int GCD(int a, int b)
    //{
    //    int gdc = 0;
    //    while (b != 0)
    //    {
    //        gdc = b;
    //        b = a % b;
    //        a = gdc;
    //    }
    //
    //    return a;
    //}

    static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }

    static void Main()
    {
        /*Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
         Use the Euclidean algorithm (find it in Internet).*/
        string input = Console.ReadLine();
        var inputArray = input.Split(' ');
        int a;
        bool userInputAIsValid = int.TryParse(inputArray[0], out a);

        int b;
        bool userInputBIsValid = int.TryParse(inputArray[1], out b);


        a = Math.Abs(a);
        b = Math.Abs(b);

        if (userInputAIsValid && userInputBIsValid)
        {
            int copyA = a;
            int copyB = b;

            int gdc = GCD(a, b);

            Console.WriteLine("{0}", gdc);
        }
        else
        {
            Console.WriteLine("Ivalid input.");
        }
    }
}
