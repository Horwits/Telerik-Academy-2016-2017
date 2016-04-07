using System;

class BitAtPositionModifier
{
    static void Main()
    {
        /*We are given an integer number N(read from the console), a bit value v(read from the console as well) (v = 0 or 1) and a position P(read from the console). Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v at the position P from the binary representation of N while preserving all other bits in N. Print the resulting number on the console.*/

        string inputNumber = Console.ReadLine();

        string inputPosition = Console.ReadLine();

        string inputBitValue = Console.ReadLine();

        long number;
        bool inputNumberIsValid = long.TryParse(inputNumber, out number);

        int position;
        bool inputPositionIsValid = int.TryParse(inputPosition, out position);

        int bitValue;
        bool inputBitValueIsValid =
            int.TryParse(inputBitValue, out bitValue) &&
            (inputBitValue == "1" || inputBitValue == "0");

        if (inputNumberIsValid &&
            inputPositionIsValid &&
            inputBitValueIsValid)
        {
            long mask = 0,
                result = 0;

            bool bitAtCurrentIsZero = bitValue == 0;

            if (bitAtCurrentIsZero)
            {
                mask = ~(1 << position);
                result = number & mask;
            }
            else
            {
                mask = 1 << position;
                result = number | mask;
            }

            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("Please, enter a valid input number.");
        }
    }
}
