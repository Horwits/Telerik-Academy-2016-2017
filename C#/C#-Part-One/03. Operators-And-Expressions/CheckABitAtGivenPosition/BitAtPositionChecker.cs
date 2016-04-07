using System;

class BitAtPositionChecker
{
    static void Main()
    {
        Console.WriteLine("Please, enter valid numbers: ");

        Console.Write("number: ");
        string inputNumber = Console.ReadLine();

        Console.Write("position: ");
        string inputPosition = Console.ReadLine();

        int number;
        bool inputNumberIsValid = int.TryParse(inputNumber, out number);

        int position;
        bool inputPositionIsValid = int.TryParse(inputPosition, out position);

        if (inputNumberIsValid && inputPositionIsValid)
        {
            int mask = 1 << position;
            int nAndMask = number & mask;
            int bit = nAndMask >> position;

            Console.WriteLine("The bit at position {0} is: {1}", position, bit == 1 ? true : false);
        }
        else
        {
            Console.WriteLine("Please, enter a valid input number.");
        }
    }
}
