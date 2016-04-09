using System;

class NamePrinter
{
    static void PrintNameOnConsole(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        var userInput = Console.ReadLine();
        PrintNameOnConsole(userInput);
    }
}
