using System;

class AdvancedBitExchanger
{
    static void Main()
    {
        /*Write a program first reads 3 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console.*/

        string inputNumber = Console.ReadLine();

        string inputP = Console.ReadLine();

        string inputQ = Console.ReadLine();

        string inputK = Console.ReadLine();

        uint number;
        bool inputNumberIsValid = uint.TryParse(inputNumber, out number);

        int p, q, k;
        bool inputPIsValid = int.TryParse(inputP, out p);
        bool inputQIsValid = int.TryParse(inputQ, out q);
        bool inputKIsValid = int.TryParse(inputK, out k);

        bool inputIsValid = inputNumberIsValid
            && inputPIsValid
            && inputKIsValid
            && inputQIsValid;

        //int outOfRange = 32;
        //bool isOutOfRange = ((p + k + q) >= outOfRange) || number > uint.MaxValue;
        //bool isOverlapping = (Math.Min(p, q) + k) > Math.Max(p, q);

        if (inputIsValid)// && !isOutOfRange && !isOverlapping)
        {
            //var bitrepstr = Convert.ToString(number, 2);
            //Console.WriteLine("Bit representation of the number before convertion: {0}{1}", bitrepstr, "\n\r");

            for (int i = 0; i <= k - 1; i++)
            {
                bool pValueIsZero = (number & (1 << p + i)) == 0;
                bool qValueIsZero = (number & (1 << q + i)) == 0;

                if (!(pValueIsZero == qValueIsZero))
                {
                    number = SetOppositeValueOfBitOnPositionInNumber(number, p + i);
                    number = SetOppositeValueOfBitOnPositionInNumber(number, q + i);
                }
            }

            //bitrepstr = Convert.ToString(number, 2);
            //Console.WriteLine("Bit representation of the number after convertion: {0}{1}", bitrepstr, "\n\r");

            Console.WriteLine("{0}", number);
        }
        //else if (isOverlapping)
        //{
        //    Console.WriteLine("Overlapping.");
        //}
        //else
        //{
        //    Console.WriteLine("Out of Range.");
        //}

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

