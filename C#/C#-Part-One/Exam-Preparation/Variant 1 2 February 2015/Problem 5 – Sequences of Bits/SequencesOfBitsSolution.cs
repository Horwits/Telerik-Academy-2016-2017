using System;

class SequencesOfBitsSolution
{
    //TODO: REMOVE UNNECESSERY CHECKS 

    static int CountLongestSetBitsSequenceInArrayOfNumbers(uint[]numbers,int numbersLength)
    {
        int currentOneLength = 0,
            maxOneLength = 0;

        bool isSequenceOneContinue = false;
        for (int row = numbersLength - 1; row >= 0; row--)
        {
            if (!isSequenceOneContinue)
            {
                currentOneLength = 0;
            }
            uint currentNum = numbers[row];
            for (int pos = 0; pos < 30; pos++)
            {
                bool isBitOne = (currentNum & (1 << pos)) != 0;
                if (isBitOne)
                {
                    currentOneLength++;
                    int posPlusOne = pos + 1;

                    if (row - 1 >= 0 && pos == 29)
                    {
                        bool bitOnNextRowIsOne = (numbers[row - 1] & (1 << 0)) != 0;
                        if (bitOnNextRowIsOne)
                        {
                            isSequenceOneContinue = true;
                        }
                    }

                    bool isBitOneOnPositionPlusOne = (currentNum & (1 << posPlusOne)) != 0;

                    if (pos != 29 && !isBitOneOnPositionPlusOne)
                    {
                        isSequenceOneContinue = false;
                    }

                    if (isBitOneOnPositionPlusOne && pos != 29)
                    {
                        continue;
                    }
                    else if (!isBitOneOnPositionPlusOne && !isSequenceOneContinue)
                    {
                        if (currentOneLength > maxOneLength)
                        {
                            maxOneLength = currentOneLength;
                        }

                        currentOneLength = 0;
                        isSequenceOneContinue = false;
                    }
                    else if (!isBitOneOnPositionPlusOne && row == 0 && pos == 29)
                    {
                        if (currentOneLength > maxOneLength)
                        {
                            maxOneLength = currentOneLength;
                        }

                        currentOneLength = 0;
                        isSequenceOneContinue = false;
                    }
                }
                else
                {
                    if (currentOneLength > maxOneLength)
                    {
                        maxOneLength = currentOneLength;
                    }

                    currentOneLength = 0;
                    isSequenceOneContinue = false;
                }
            }
        }

        return maxOneLength;
    }

    static int CountLongestZeroBitSequenceInArrayOfNumbers(uint[] numbers, int numbersLength)
    {
        int currentLength = 0,
            maxLength = 0;

        bool isSequenceContinue = false;
        for (int row = numbersLength - 1; row >= 0; row--)
        {
            if (!isSequenceContinue)
            {
                currentLength = 0;
            }

            uint currentNum = numbers[row];
            for (int pos = 0; pos < 30; pos++)
            {
                bool isBitZero = (currentNum & (1 << pos)) == 0;
                if (isBitZero)
                {
                    currentLength++;
                    int posPlusOne = pos + 1;

                    if (row - 1 >= 0 && pos == 29)
                    {
                        bool bitOnNextRowIsZero = (numbers[row - 1] & (1 << 0)) == 0;
                        if (bitOnNextRowIsZero)
                        {
                            isSequenceContinue = true;
                        }
                        else
                        {
                            isSequenceContinue = false;
                        }
                    }

                    bool isBitZeroOnPositionPlusOne = (currentNum & (1 << posPlusOne)) == 0;

                    if (isBitZeroOnPositionPlusOne && pos != 29)
                    {
                        continue;
                    }
                    else if (pos == 29 && isBitZeroOnPositionPlusOne && row == 0)
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                        }
                    }
                    else if (pos == 29 && isBitZeroOnPositionPlusOne && !isSequenceContinue)
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                        }
                    }
                    else if (!isBitZeroOnPositionPlusOne && !isSequenceContinue)
                    {
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                        }

                        currentLength = 0;
                        isSequenceContinue = false;
                    }
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    if (!isSequenceContinue)
                    {
                        continue;
                    }
                    else
                    {
                        currentLength = 0;
                        isSequenceContinue = false;
                    }
                }
            }
        }

        return maxLength;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        uint[] numbers = new uint[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }

        int maxOneLength = CountLongestSetBitsSequenceInArrayOfNumbers(numbers, n);
        int maxZeroLength = CountLongestZeroBitSequenceInArrayOfNumbers(numbers, n);
        Console.WriteLine(maxOneLength);
        Console.WriteLine(maxZeroLength);
    }
}
