using System;

class NotDivisibleByConditionSequence
{
    static void Main()
    {
        /*Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 or 7, on a single line, separated by a space.*/

        string input = Console.ReadLine();

        short n;
        var inputIsValid = short.TryParse(input, out n);

        if (inputIsValid)
        {
            short i = 1;
            string output = string.Format("{0}", i);
            for (i = 2; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }

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
