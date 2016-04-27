using System;

class Program
{
    static void Main()
    {
        byte secret = byte.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        decimal encodedResult = 0;
        int counter = 0;

        foreach (var sym in text)
        {
            if (sym == '@')
            {
                break;
            }
            else if (char.IsDigit(sym))
            {
                encodedResult = sym + secret + 500;
            }
            else if (char.IsLetter(sym))
            {
                encodedResult = sym * secret + 1000;
            }
            else
            {
                encodedResult = sym - secret;
            }

            if (counter % 2 == 0)
            {
                Console.WriteLine("{0:f2}", encodedResult / 100);
            }
            else
            {
                Console.WriteLine("{0}", encodedResult * 100);
            }
            counter++;
        }
    }
}
