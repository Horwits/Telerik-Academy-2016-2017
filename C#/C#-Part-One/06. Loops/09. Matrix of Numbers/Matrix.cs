using System;

class Matrix
{
    static void Main()
    {
        /*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

        n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
        */

        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 20)
        {
            int counter;
            for (int i = 1; i <= n; i++)
            {
                counter = i;
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0} ", counter);
                    counter++;
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
