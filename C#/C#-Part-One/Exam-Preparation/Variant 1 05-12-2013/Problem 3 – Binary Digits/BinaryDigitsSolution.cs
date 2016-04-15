using System;

class BinaryDigitsSolution
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        string binary = Convert.ToString(n, 2).PadLeft(16, '0');
        int length = binary.Length;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < length; j++)
            {
                char currentDigit = binary[j];
                switch (currentDigit)
                {
                    case '0':
                        switch (i)
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
                                Console.Write("###");
                                break;
                        }

                        if (j < length - 1)
                        {
                            Console.Write('.');
                        }

                        break;
                    case '1':
                        switch (i)
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
                                Console.Write("###");
                                break;
                        }

                        if (j < length - 1)
                        {
                            Console.Write('.');
                        }

                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
