using System;
using System.Collections.Generic;

class IntervalDivision
{
    static void Main()
    {
        /*Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them such that the reminder of the division by 5 is 0.*/

        string inputStart = Console.ReadLine();
        string inputEnd = Console.ReadLine();

        int start;
        bool inputStartIsValid = int.TryParse(inputStart, out start);

        int end;
        bool inputEndIsValid = int.TryParse(inputEnd, out end);

        if (inputStartIsValid && inputEndIsValid)
        {
            //List<int> collector = new List<int>();
            start++;
            int p = 0;
            for (int i = start; i < end; i++)
            {
                if (i % 5 == 0)
                {
                    //collector.Add(i);
                    p++;
                }
            }
            Console.WriteLine("{0}", p);
        }
        else
        {
            string errorMessage = "Ivalid input.";
            Console.WriteLine(errorMessage);
        }
    }
}
