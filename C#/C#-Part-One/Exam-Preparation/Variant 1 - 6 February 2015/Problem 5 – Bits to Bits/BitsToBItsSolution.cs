using System;

class BitsToBItsSolution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var numbers = new string[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(30, '0');
        }

        int maxLengthOfZeroes = 0,
            maxLengthOfOnes = 0;

        int currentLengthOfZeroes = 0,
            currentLengthOfOnes = 0;

        bool isCurrentSeqOfOnesContinues = false,
            isCurrentSeqOFZeroesContinues = false;

        for (int row = 0; row < n; row++)
        {
            int length = 30;

            for (int currentPos = 0; currentPos < 30; currentPos++)
            {
                int currentPosPlusOne = currentPos + 1;

                char currentDigit = numbers[row][currentPos];
                char nextDigit = 'X';
                if (currentPosPlusOne >= length)
                {
                    nextDigit = 'X';
                }
                else
                {
                    nextDigit = numbers[row][currentPosPlusOne];
                }

                bool isNextRowZeroPosValueOne = row + 1 < n && numbers[row + 1][0] == '1',
                    isNextRowZeroPosValueZero = row + 1 < n && numbers[row + 1][0] == '0';

                if ((currentDigit == '1'))
                {
                    currentLengthOfOnes++;
                    currentLengthOfZeroes = 0;

                    if (currentPos == length - 1 && isNextRowZeroPosValueOne)
                    {
                        isCurrentSeqOfOnesContinues = true;
                    }
                    else
                    {
                        isCurrentSeqOfOnesContinues = false;
                    }

                    if (currentDigit == nextDigit)
                    {
                        continue;
                    }
                }
                else if ((currentDigit == '0'))
                {
                    currentLengthOfZeroes++;
                    currentLengthOfOnes = 0;

                    if (currentPos == length - 1 && isNextRowZeroPosValueZero)
                    {
                        isCurrentSeqOFZeroesContinues = true;
                    }
                    else
                    {
                        isCurrentSeqOFZeroesContinues = false;
                    }

                    if (currentDigit == nextDigit)
                    {
                        continue;
                    }
                }

                if (currentLengthOfOnes > maxLengthOfOnes)
                {
                    maxLengthOfOnes = currentLengthOfOnes;
                }

                if (currentLengthOfZeroes > maxLengthOfZeroes)
                {
                    maxLengthOfZeroes = currentLengthOfZeroes;
                }
            }
        }

        Console.WriteLine(maxLengthOfZeroes);
        Console.WriteLine(maxLengthOfOnes);
    }
}
