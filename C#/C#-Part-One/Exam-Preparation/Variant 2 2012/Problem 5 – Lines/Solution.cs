using System;
using System.Collections.Generic;

class Solution
{
    const int _LENGTH = 8;

    static int CountLongestSequences(byte[] grid, int maxSequenceLength)
    {
        int counter = 0;

        int currentHorizontalSequenceLength = 1,
            currentVerticalSequenceLength = 1;

        for (int line = 0; line < _LENGTH; line++)
        {
            for (int cell = 0; cell < _LENGTH; cell++)
            {
                bool isBitOne = (grid[line] & (1 << cell)) != 0;

                if (isBitOne)
                {
                    currentHorizontalSequenceLength = 1;
                    currentVerticalSequenceLength = 1;

                    //horizontal
                    if (cell + currentHorizontalSequenceLength < _LENGTH)
                    {
                        bool isOneOnNextPositionsHorizontal = (grid[line] & (1 << cell + currentHorizontalSequenceLength)) != 0;

                        while (isOneOnNextPositionsHorizontal && currentHorizontalSequenceLength + cell < _LENGTH)
                        {
                            currentHorizontalSequenceLength++;
                            if (currentHorizontalSequenceLength + cell < _LENGTH)
                            {
                                isOneOnNextPositionsHorizontal = (grid[line] & (1 << cell + currentHorizontalSequenceLength)) != 0;
                            }
                        }
                    }

                    //vertical
                    if (line + currentVerticalSequenceLength < _LENGTH)
                    {
                        bool isOneOnNextPositionsVertical = (grid[line + currentVerticalSequenceLength] & (1 << cell)) != 0;

                        while (isOneOnNextPositionsVertical && currentVerticalSequenceLength + line < _LENGTH)
                        {
                            currentVerticalSequenceLength++;
                            if (currentVerticalSequenceLength + line < _LENGTH)
                            {
                                isOneOnNextPositionsVertical = (grid[line + currentVerticalSequenceLength] & (1 << cell)) != 0;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }

                if (currentHorizontalSequenceLength == maxSequenceLength)
                {
                    counter++;
                }

                if (currentVerticalSequenceLength == maxSequenceLength)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    static void Main()
    {

        byte[] grid = new byte[_LENGTH];

        for (int i = 0; i < _LENGTH; i++)
        {
            grid[i] = byte.Parse(Console.ReadLine());
        }

        int maxHorizontalSequenceLength = 0,
            maxVerticalSequenceLength = 0;

        for (int line = 0; line < _LENGTH; line++)
        {
            int currentHorizontalSequenceLength = 1;
            int currentVerticalSequenceLength = 1;

            for (int cell = 0; cell < _LENGTH; cell++)
            {
                bool isBitOne = (grid[line] & (1 << cell)) != 0;

                if (isBitOne)
                {
                    //horizontal
                    if (cell + currentHorizontalSequenceLength < _LENGTH)
                    {
                        bool isOneOnNextPositionsHorizontal = (grid[line] & (1 << cell + currentHorizontalSequenceLength)) != 0;

                        while (isOneOnNextPositionsHorizontal && currentHorizontalSequenceLength + cell < _LENGTH)
                        {
                            currentHorizontalSequenceLength++;
                            if (currentHorizontalSequenceLength + cell < _LENGTH)
                            {
                                isOneOnNextPositionsHorizontal = (grid[line] & (1 << cell + currentHorizontalSequenceLength)) != 0;
                            }
                        }
                    }

                    //vertical
                    if (line + currentVerticalSequenceLength < _LENGTH)
                    {
                        bool isOneOnNextPositionsVertical = (grid[line + currentVerticalSequenceLength] & (1 << cell)) != 0;

                        while (isOneOnNextPositionsVertical && currentVerticalSequenceLength + line < _LENGTH)
                        {
                            currentVerticalSequenceLength++;
                            if (currentVerticalSequenceLength + line < _LENGTH)
                            {
                                isOneOnNextPositionsVertical = (grid[line + currentVerticalSequenceLength] & (1 << cell)) != 0;
                            }
                        }
                    }
                }
                else
                {
                    continue;
                }
            }

            if (currentHorizontalSequenceLength > maxHorizontalSequenceLength)
            {
                maxHorizontalSequenceLength = currentHorizontalSequenceLength;
            }

            if (currentVerticalSequenceLength > maxVerticalSequenceLength)
            {
                maxVerticalSequenceLength = currentVerticalSequenceLength;
            }
        }

        int maxSequenceLength = Math.Max(maxHorizontalSequenceLength, maxVerticalSequenceLength);
        Console.WriteLine(maxSequenceLength);

        int counter = CountLongestSequences(grid, maxSequenceLength);
        Console.WriteLine(counter);

    }
}
