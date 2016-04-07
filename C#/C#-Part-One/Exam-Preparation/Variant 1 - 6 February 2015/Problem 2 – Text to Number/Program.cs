using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;
        foreach (var symbol in text)
        {
            if (symbol == '@')
            {
                break;
            }
            else if (char.IsDigit(symbol))
            {
                result *= (symbol - '0');
            }
            else if (char.IsLetter(symbol))
            {
                char currentLetter = char.ToUpper(symbol);

                result += (currentLetter - 'A');
            }
            else
            {
                result %= m;
            }
        }

        Console.WriteLine(result);
    }
}
