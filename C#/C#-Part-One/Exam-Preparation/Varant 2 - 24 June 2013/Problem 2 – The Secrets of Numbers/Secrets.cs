using System;
using System.Numerics;
using System.Text;

class Secrets
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());

        var copyNumber = number;

        if (copyNumber < 0)
        {
            copyNumber *= -1;
        }

        int specialSum = 0;
        int position = 0;
        while (copyNumber > 0)
        {
            int digit = (int)(copyNumber % 10);
            position++;
            if (position % 2 == 1)
            {
                //int oddResult = digit * position * position;
                specialSum += digit * position * position;
            }
            else
            {
                //int evenResult = digit * digit * position;
                specialSum += digit * digit * position;
            }

            copyNumber /= 10;
        }

        Console.WriteLine(specialSum);

        bool isSASLengthZero = specialSum % 10 == 0;
        if (isSASLengthZero)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }
        else
        {
            int remainder = specialSum % 26;
            int secretAlphaSequenceLength = specialSum % 10;
            StringBuilder secretAlphaSequence = new StringBuilder();


            for (int i = 0, counter = 0; i < secretAlphaSequenceLength; i++)
            {
                char letter = '\u0000';
                if ((remainder + i) < 26)
                {
                    letter = (char)(remainder + counter + 'A');
                }
                else
                {
                    if (counter == i)
                    {
                        counter = 0;
                    }

                    letter = (char)((counter + 'A'));
                }

                secretAlphaSequence.Append(letter);

                counter++;
            }

            Console.WriteLine(secretAlphaSequence.ToString());
        }
    }
}
