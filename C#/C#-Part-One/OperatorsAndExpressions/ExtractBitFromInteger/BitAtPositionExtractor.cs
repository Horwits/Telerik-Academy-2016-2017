using System;

class BitAtPositionExtractor
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        string inputPosition = Console.ReadLine();

        int number;
        bool inputNumberIsValid = int.TryParse(inputNumber, out number);

        int position;
        bool inputPositionIsValid = int.TryParse(inputPosition, out position);

        if (inputNumberIsValid)
        {
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
