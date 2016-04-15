using System;

class ApplesOrOrangesSolution
{
    static void Main()
    {
        string number = Console.ReadLine();

        int evenSum = 0,
            oddSum = 0; 
        foreach (var symbol in number)
        {
            if (symbol == '-')
            {
                continue;
            }

            int currentDigit = symbol - '0';
            if (currentDigit % 2 == 0)
            {
                evenSum += currentDigit;
            }
            else
            {
                oddSum += currentDigit;
            }
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("apples {0}", evenSum);
        }
        else if (oddSum > evenSum)
        {
            Console.WriteLine("oranges {0}", oddSum);
        }
        else
        {
            Console.WriteLine("both {0}", evenSum);
        }
    }
}
