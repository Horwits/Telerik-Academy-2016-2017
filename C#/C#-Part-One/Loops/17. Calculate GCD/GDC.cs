using System;

class GDC
{
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

        if (userInputAIsValid && userInputBIsValid)
        {
            int copyA = a;
            int copyB = b;

            int gdc = 0;
            while (copyB != 0)
            {
                gdc = copyB;
                copyB = copyA % copyB;
                copyA = gdc;
            }

            Console.WriteLine("{0}", gdc);
        }
        else
        {
            Console.WriteLine("Ivalid input.");
        }
    }
}
