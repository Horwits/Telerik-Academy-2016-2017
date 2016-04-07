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

        string nToBin = Convert.ToString(n, 2).PadLeft(16, '0');
        int length = nToBin.Length;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (j == length - 1)
                {
                    PrintBinaryLastDigit(nToBin[j], i);
                }
                else
                {
                    PrintBinary(nToBin[j], i);
                }
            }

            Console.WriteLine();
        }
    }
}
