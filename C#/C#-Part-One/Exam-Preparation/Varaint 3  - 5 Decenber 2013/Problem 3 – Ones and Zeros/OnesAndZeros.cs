using System;

class OnesAndZeros
{
    static void PrintBinaryLastDigit(char digit, int row)
    {
        switch (digit)
        {
            case '1':
                switch (row)
                {
                    case 0:
                        Console.Write(".#.");
                        break;
                    case 1:
                        Console.Write("##.");
                        break;
                    case 2:
                        Console.Write(".#.");
                        break;
                    case 3:
                        Console.Write(".#.");
                        break;
                    case 4:
                        Console.Write("###");
                        break;
                }
                break;
            case '0':
                switch (row)
                {
                    case 0:
                        Console.Write("###");

                        break;
                    case 1:
                        Console.Write("#.#");
                        break;
                    case 2:
                        Console.Write("#.#");
                        break;
                    case 3:
                        Console.Write("#.#");
                        break;
                    case 4:
                        Console.Write("###");
                        break;
                }

                break;
        }
    }

    static void PrintBinary(char digit, int row)
    {
        switch (digit)
        {
            case '1':
                switch (row)
                {
                    case 0:
                        Console.Write(".#..");
                        break;
                    case 1:
                        Console.Write("##..");
                        break;
                    case 2:
                        Console.Write(".#..");
                        break;
                    case 3:
                        Console.Write(".#..");
                        break;
                    case 4:
                        Console.Write("###.");
                        break;
                }
                break;
            case '0':
                switch (row)
                {
                    case 0:
                        Console.Write("###.");
                        break;
                    case 1:
                        Console.Write("#.#.");
                        break;
                    case 2:
                        Console.Write("#.#.");
                        break;
                    case 3:
                        Console.Write("#.#.");
                        break;
                    case 4:
                        Console.Write("###.");
                        break;
                }
                break;
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(n, 2).PadLeft(32, '0');
        string lastBits = binary.Substring(16, 16);

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                if (j == 15)
                {
                    PrintBinaryLastDigit(lastBits[j], i);
                }
                else
                {
                    PrintBinary(lastBits[j], i);
                }
            }

            Console.WriteLine();
        }
    }
}
