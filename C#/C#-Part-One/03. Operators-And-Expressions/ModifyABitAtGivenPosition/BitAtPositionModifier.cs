using System;
using System.Text;

class BitAtPositionModifier
{
    static void Main()
    {
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
            var sb = new StringBuilder();
            string bitwiseRep = Convert.ToString(number, 2).PadLeft(64, '0');
            sb.Append(bitwiseRep);
            var currentPosition = 64 - (position + 1);
            if (bitValue == 1)
            {
                sb[currentPosition] = '1';
            }
            else
            {
                sb[currentPosition] = '0';
            }

            string reversed = sb.ToString();

            var result = Convert.ToUInt64(reversed, 2);

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Please, enter a valid input number.");
        }
    }
}
