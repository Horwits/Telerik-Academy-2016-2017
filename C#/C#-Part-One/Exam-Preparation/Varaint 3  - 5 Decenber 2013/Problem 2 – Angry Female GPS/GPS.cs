using System;

class GPS
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        int length = inputNumber.Length,
            evenSum = 0,
            oddSum = 0;
        for (int i = 0; i < length; i++)
        {
            int digit = 0;
            if (inputNumber[i] == '-')
            {
                continue;
            }
            else
            {
                digit = inputNumber[i] - '0';

                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
            }
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("{0} {1}", "right", evenSum);
        }
        else if (oddSum > evenSum)
        {
            Console.WriteLine("{0} {1}", "left", oddSum);
        }
        else
        {
            Console.WriteLine("{0} {1}", "straight", oddSum);
        }
    }
}
