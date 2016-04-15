using System;
using System.Text;

class BitTOwerOFDoomSOlution
{
    static void Main()
    {
        StringBuilder[] chariots = new StringBuilder[8];
        for (int i = 0; i < 8; i++)
        {
            chariots[i] = new StringBuilder();
            chariots[i].Append(Convert.ToString(int.Parse(Console.ReadLine()), 2).PadLeft(8, '0'));
        }

        int warriours = 0;
        foreach (var chariot in chariots)
        {
            for (int i = 0; i < 8; i++)
            {
                char currentSymbol = chariot[i];
                if (currentSymbol == '1')
                {
                    warriours++;
                }
            }
        }

        int dead = 0;
        while (true)
        {
            var command = Console.ReadLine();
            if (command == "end")
            {
                break;
            }

            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());

            if (col > 7 || col < 0)
            {
                if (row > 1)
                {
                    dead++;
                }

                continue;
            }

            if (command == "select")
            {
                chariots[row][col] = '0';
                continue;
            }

            char currentPositionValue = chariots[row][col];

            char currentPositionRightValue = '0';
            if (col + 1 < 8)
            {
                currentPositionRightValue = chariots[row][col + 1];
            }

            char currentPositionLeftValue = '0';
            if (col - 1 >= 0)
            {
                currentPositionLeftValue = chariots[row][col - 1];
            }

            bool willDieInMoveCommand = command == "move" && currentPositionValue == '1' && (currentPositionLeftValue == '1' && currentPositionRightValue == '0' || currentPositionRightValue == '1' && currentPositionLeftValue == '0') || currentPositionValue == '1' && (currentPositionLeftValue == '1' && currentPositionRightValue == '1') || currentPositionValue == '0' && (currentPositionLeftValue == '1' && currentPositionRightValue == '1') ||
                 currentPositionValue == '0' && (currentPositionLeftValue == '1' && currentPositionRightValue == '0' || currentPositionRightValue == '1' && currentPositionLeftValue == '0');

            bool willDie = command != "move" && currentPositionValue == '0' && (currentPositionLeftValue == '1' && currentPositionRightValue == '1');

            bool willKill = command != "move" && currentPositionValue == '1' && (currentPositionLeftValue == '0' && currentPositionRightValue == '0');

            bool wilKillAndDie = command != "move" && currentPositionValue == '0' && (currentPositionLeftValue == '1' && currentPositionRightValue == '0' || currentPositionRightValue == '1' && currentPositionLeftValue == '0');

            if (command == "move")
            {
                if (willDieInMoveCommand)
                {
                    dead++;
                }
                else
                {
                    chariots[row][col] = '1';
                }
            }
            else if (command == "kill")
            {
                if (willKill)
                {
                    chariots[row][col] = '1';
                    dead++;
                }
                else if (wilKillAndDie)
                {
                    if (currentPositionLeftValue == '1' && currentPositionRightValue == '0')
                    {
                        chariots[row][col - 1] = '0';
                    }

                    if (currentPositionRightValue == '1' && currentPositionLeftValue == '0')
                    {
                        chariots[row][col + 1] = '0';
                    }

                    dead += 2;
                }
                else if (willDie)
                {
                    dead++;
                }
                else
                {
                    chariots[row][col] = '1';
                }
            }
        }

        int survivors = 0;
        long sum = 0;
        foreach (var chariot in chariots)
        {
            for (int i = 0; i < 8; i++)
            {
                char currentSymbol = chariot[i];
                if (currentSymbol == '1')
                {
                    survivors++;
                }
            }

            long lastedChariots = ConvertBinaryToDecimal(chariot.ToString());

            if (lastedChariots > 0)
            {
                sum += lastedChariots;
            }
        }

        Console.WriteLine(warriours);
        Console.WriteLine(survivors);
        Console.WriteLine(sum);
    }

    static long ConvertBinaryToDecimal(string binary)
    {
        int currentPosition = 0,
            length = binary.Length;

        long decimalRepresentation = 0;
        for (int i = length - 1; i >= 0; i--)
        {
            int currentDigit = binary[i] - '0';
            decimalRepresentation += (currentDigit * (long)Math.Pow(2, currentPosition));
            currentPosition++;
        }

        return decimalRepresentation;
    }
}
