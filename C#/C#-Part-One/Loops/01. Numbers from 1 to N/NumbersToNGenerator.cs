using System;

class NumbersToNGenerator
{
    static void Main()
    {
        /*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.*/

        string input = Console.ReadLine();

        int n;
        var inputIsValid = int.TryParse(input, out n);

        if (inputIsValid)
        {
            int i = 1;
            string output = string.Format("{0}", i);
            for (i = 2; i <= n; i++)
            {
                output += string.Format(" {0}", i);
            }

            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
