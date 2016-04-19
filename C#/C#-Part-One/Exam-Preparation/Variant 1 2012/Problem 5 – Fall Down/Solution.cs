using System;

class Solution
{
    static byte SetBitToOne(byte value, byte position)
    {
        return value = (byte)(value | (1 << position));
    }

    static byte SetBitToZero(byte value, byte position)
    {
        return value = (byte)(value & ~(1 << position));
    }

    static void Main()
    {
        byte[] grid = new byte[8];
        for (int i = 0; i < 8; i++)
        {
            grid[i] = byte.Parse(Console.ReadLine());
        }

        for (byte line = 0; line < 8; line++)
        {
            for (byte cell = 0; cell < 8; cell++)
            {
                if (line + 1 < 8)
                {
                    bool isBitSet = (grid[line] & (1 << cell)) != 0;

                    if (isBitSet)
                    {
                        int lineToCheck = (7 - line) + line;

                        while (true)
                        {
                            bool isBitSetOnLine = (grid[lineToCheck] & (1 << cell)) != 0;
                            if (isBitSetOnLine && lineToCheck > line)
                            {
                                lineToCheck--;
                            }
                            else
                            {
                                break;
                            }
                        }

                        grid[line] = SetBitToZero(grid[line], cell);
                        grid[lineToCheck] = SetBitToOne(grid[lineToCheck], cell);
                    }
                }
            }
        }

        foreach (var item in grid)
        {
            Console.WriteLine(item);
        }
    }
}
