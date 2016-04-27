using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        long sum = 0;

        int length = text.Length,
            counter = 0;
        for (int i = 0; i < length; i++)
        {
            if (i % 2 == 0)
            {
                if (char.IsDigit(text[i]))
                {
                    sum += text[i] - '0';
                    counter++;
                }
            }
        }

        Console.WriteLine(counter + " " + sum);
    }
}
