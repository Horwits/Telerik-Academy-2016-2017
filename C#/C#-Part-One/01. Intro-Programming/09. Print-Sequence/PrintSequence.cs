using System;

class SequencePrinter
{
    static void Main()
    {
        /*Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

        var sequanceLength = 10;

        for (int i = 2; i <= sequanceLength; i++)
        {
            int indexer = i;
            if (i % 2 == 1)
            {
                indexer = i * (-1);
            }
            Console.Write(indexer + " ");
        }
        Console.ReadKey();
    }
}
