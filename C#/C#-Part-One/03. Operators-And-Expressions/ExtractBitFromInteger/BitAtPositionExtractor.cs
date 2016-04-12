using System;

class BitAtPositionExtractor
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        string inputPosition = Console.ReadLine();

        long number;
        bool inputNumberIsValid = long.TryParse(inputNumber, out number);

        int position;
        bool inputPositionIsValid = int.TryParse(inputPosition, out position);

        if (inputNumberIsValid)
        {
            int mask = 1 << position;
            long nAndMask = number & mask;
            long bit = nAndMask >> position;

            Console.WriteLine("{0}", bit);
        }
        else
        {
            Console.WriteLine("Please, enter a valid input number.");
        }
    }
}
