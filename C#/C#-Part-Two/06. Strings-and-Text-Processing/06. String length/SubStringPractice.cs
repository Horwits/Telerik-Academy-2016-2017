using System;

class SubStringPractice
{
    static void Main()
    {
        string text = "hello";
        text = text.PadRight(20, '*');

        Console.WriteLine(text);
    }
}
