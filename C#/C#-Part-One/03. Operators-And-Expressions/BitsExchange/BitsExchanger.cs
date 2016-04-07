using System;

class BitsExchanger
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32 - bit unsigned integer.

        string inputNumber = Console.ReadLine();
        
        uint number;
        bool inputNumberIsValid = uint.TryParse(inputNumber, out number);

        
        if (inputNumberIsValid)
        {
            //case 1 --> if the bits on both positions are equal --> continue
            //our only one case is : when they're different.
            //we have to get the bit on the first position and to find what is it's value

            bool bitThreeIsZero = (number & (1 << 3)) == 0,
                bitTwentyFourIsZero = (number & (1 << 24)) == 0,
                
                bitFourIsZero = (number & (1 << 4)) == 0,
                bitTwentyFiveIsZero = (number & (1 << 25)) == 0,
                
                bitFiveIsZero = (number & (1 << 5)) == 0,
                bitTwentySixIsZero = (number & (1 << 26)) == 0;

            //var bitrepstr = Convert.ToString(number, 2);
            //Console.WriteLine(bitrepstr);

            if (!(bitThreeIsZero == bitTwentyFourIsZero))
            {
                number = SetOppositeValueOfBitOnPositionInNumber(number, 3);
                number = SetOppositeValueOfBitOnPositionInNumber(number, 24);
            }

            if (!(bitFourIsZero == bitTwentyFiveIsZero))
            {
                number = SetOppositeValueOfBitOnPositionInNumber(number, 4);
                number = SetOppositeValueOfBitOnPositionInNumber(number, 25);
            }

            if (!(bitFiveIsZero == bitTwentySixIsZero))
            {
                number = SetOppositeValueOfBitOnPositionInNumber(number, 5);
                number = SetOppositeValueOfBitOnPositionInNumber(number, 26);
            }

            //bitrepstr = Convert.ToString(number, 2);
            //Console.WriteLine(bitrepstr);

            Console.WriteLine("{0}", number);
        }
        else
        {
            Console.WriteLine("Please, enter a valid input number.");
        }
    }

    static uint SetOppositeValueOfBitOnPositionInNumber(uint number, int position)
    {
        bool bitIsZero = (number & (1 << position)) == 0;

        uint result = 0;
        uint mask;
        if (!bitIsZero)
        {
            mask = ~(1u << position);
            result = number & mask;
        }
        else
        {
            mask = 1u << position;
            result = number | mask;
        }

        return result;
    }
}
