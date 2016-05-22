using System;

class StringLength
{
    static void Main()
    {
        string text = Console.ReadLine();
        text = text.Replace(@"\", string.Empty);
        Console.WriteLine(text.PadRight(20, '*'));
    }
}
