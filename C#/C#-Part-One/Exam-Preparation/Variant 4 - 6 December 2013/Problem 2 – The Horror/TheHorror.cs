using System;

class TheHorror
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        int length = inputText.Length;
        int totalAmountOfDigits = 0,
            evenSum = 0;

        for (int i = 0; i < length; i++)
        {
            if (i % 2 == 0)
            {
                if (char.IsDigit(inputText[i]))
                {
                    evenSum += inputText[i] - '0';
                    totalAmountOfDigits++;
                }
            }
        }

        Console.WriteLine("{0} {1}", totalAmountOfDigits, evenSum);
    }
}
