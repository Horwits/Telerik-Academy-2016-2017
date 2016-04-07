using System;

class BitExtractor
{
    static void Main()
    {
        /*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
        The bits are counted from right to left, starting from bit #0.
        The result of the expression should be either 1 or 0.*/

        string input = Console.ReadLine();

        int number;
        bool inputIsValid = int.TryParse(input, out number);

        if (inputIsValid)
        {
            int position = 3;
            int mask = 1 << position;
            int nAndMask = number & mask;
            int bit = nAndMask >> position;

            Console.WriteLine("{0}", bit);
        }
        else
        {
            Console.WriteLine("Please, enter a valid input number.");
        }
    }
}
