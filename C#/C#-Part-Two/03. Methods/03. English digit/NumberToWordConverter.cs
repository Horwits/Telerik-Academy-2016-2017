using System;

class NumberToWordConverter
{
    static string ConvertLastDigitAsWord(int number)
    {
        byte digit = (byte)(number % 10);
        string wordRepresentation = string.Empty;

        switch (digit)
        {
            case 0:
                wordRepresentation = "zero";
                break;
            case 1:
                wordRepresentation = "one";
                break;
            case 2:
                wordRepresentation = "two";
                break;
            case 3:
                wordRepresentation = "three";
                break;
            case 4:
                wordRepresentation = "four";
                break;
            case 5:
                wordRepresentation = "five";
                break;
            case 6:
                wordRepresentation = "six";
                break;
            case 7:
                wordRepresentation = "seven";
                break;
            case 8:
                wordRepresentation = "eight";
                break;
            case 9:
                wordRepresentation = "nine";
                break;
        }

        return wordRepresentation;
    }

    static void Main()
    {
        var input = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertLastDigitAsWord(input));
    }
}
