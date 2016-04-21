using System;

class Solution
{
    static char ReturnAnacciSequenceNumber(int input)
    {
        char result = ' ';
        switch (input)
        {
            case 1: result = 'A'; break;
            case 2: result = 'B'; break;
            case 3: result = 'C'; break;
            case 4: result = 'D'; break;
            case 5: result = 'E'; break;
            case 6: result = 'F'; break;
            case 7: result = 'G'; break;
            case 8: result = 'H'; break;
            case 9: result = 'I'; break;
            case 10: result = 'J'; break;
            case 11: result = 'K'; break;
            case 12: result = 'L'; break;
            case 13: result = 'M'; break;
            case 14: result = 'N'; break;
            case 15: result = 'O'; break;
            case 16: result = 'P'; break;
            case 17: result = 'Q'; break;
            case 18: result = 'R'; break;
            case 19: result = 'S'; break;
            case 20: result = 'T'; break;
            case 21: result = 'U'; break;
            case 22: result = 'V'; break;
            case 23: result = 'W'; break;
            case 24: result = 'X'; break;
            case 25: result = 'Y'; break;
            case 26: result = 'Z'; break;
        }

        return result;
    }

    static void Main()
    {
        string firstStr = Console.ReadLine();
        char firstLetter = firstStr[0];
        string secondStr = Console.ReadLine();
        char secondLetter = secondStr[0];
        int length = int.Parse(Console.ReadLine());

        int j = 0;
        while (j < 2 && j < length)
        {
            if (j == 0)
            {
                Console.WriteLine(firstLetter);
            }
            else if (j == 1)
            {
                char firstLetterCopy = secondLetter;

                int sum = (firstLetter - 'A' + 1) + (secondLetter - 'A' + 1);
                if (sum > 26)
                {
                    sum %= 26;
                }

                secondLetter = ReturnAnacciSequenceNumber(sum);
                firstLetter = firstLetterCopy;
                Console.WriteLine("{0}{1}", firstLetter, secondLetter);
            }
            else
            {
                j++;
                break;
            }

            j++;
        }

        if (j == 2)
        {
            int distance = 0;
            for (int i = 0; i < length - j; i++)
            {
                int firstSum = (firstLetter - 'A' + 1) + (secondLetter - 'A' + 1);
                if (firstSum > 26)
                {
                    firstSum = (firstSum % 26);
                }

                int secondSum = (secondLetter - 'A' + 1) + firstSum;
                if (secondSum > 26)
                {
                    secondSum = (secondSum % 26);
                }

                firstLetter = ReturnAnacciSequenceNumber(firstSum);
                secondLetter = ReturnAnacciSequenceNumber(secondSum);

                distance++;

                Console.WriteLine("{0}{1}{2}", firstLetter, new string(' ', distance), secondLetter);
            }
        }
    }
}
