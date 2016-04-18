using System;

class DecodingSolution
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());

        string text = Console.ReadLine();

        int length = text.Length;
        for (int i = 0; i < length; i++)
        {
            char currentChar = text[i];

            if (currentChar == '@')
            {
                break;
            }

            double currentEncodedValue = 0;
            if (char.IsLetter(currentChar))
            {
                currentEncodedValue = currentChar * salt + 1000;
            }
            else if (char.IsDigit(currentChar))
            {
                currentEncodedValue = currentChar + salt + 500;
            }
            else
            {
                currentEncodedValue = currentChar - salt;
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("{0:f2}", currentEncodedValue / 100);
            }
            else
            {
                Console.WriteLine("{0}", currentEncodedValue * 100);
            }
        }
    }
}
