using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string text = Console.ReadLine();

        int length = text.Length;
        decimal sum = 0;
        int counter = 0;
        for (int i = 0; i < length; i++)
        {
            if (char.IsDigit(text[i]) && i % 2 == 1)
            {
                counter++;
                sum += text[i] - '0';
            }
        }

        Console.WriteLine("{0} {1}", counter, sum);
    }
}
