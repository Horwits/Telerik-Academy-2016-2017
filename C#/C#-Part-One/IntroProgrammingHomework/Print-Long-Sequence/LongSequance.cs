using System;

class LongSequancePrinter
{
    static void Main()
    {
        /*Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
        You might need to learn how to use loops in C# (search in Internet).*/

        var sequanceLength = 1001;

        for (int i = 2; i <= sequanceLength; i++)
        {
            int indexer = i;
            if (i % 2 == 1)
            {
                indexer = i * (-1);
            }

            Console.WriteLine(indexer);
        }
    }
}
