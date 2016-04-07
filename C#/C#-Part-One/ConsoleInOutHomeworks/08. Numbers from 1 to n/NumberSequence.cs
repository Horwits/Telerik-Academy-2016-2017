using System;

class NumberSequence
{
    static void Main()
    {
        /*Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line.*/

        string input = Console.ReadLine();

        ushort intervalLength;
        bool inputIsValid = ushort.TryParse(input, out intervalLength);

        if (inputIsValid)
        {
            for (int i = 1; i <= intervalLength; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }
        else
        {
            string errorMessage = "Ivalid input number.";
            Console.WriteLine(errorMessage);
        }
    }
}
