using System;

class DigitToNumberGenerator
{
    static void Main()
    {
        /*Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
        Print “not a digit” in case of invalid input.
        Use a switch statement.*/

        string digitString = Console.ReadLine();

        string digitToWord = string.Empty;
        bool isNotDigit = false;
        switch (digitString)
        {
            case "0": digitToWord = "zero"; break;
            case "1": digitToWord = "one"; break;
            case "2": digitToWord = "two"; break;
            case "3": digitToWord = "three"; break;
            case "4": digitToWord = "four"; break;
            case "5": digitToWord = "five"; break;
            case "6": digitToWord = "six"; break;
            case "7": digitToWord = "seven"; break;
            case "8": digitToWord = "eight"; break;
            case "9": digitToWord = "nine"; break;
            default: isNotDigit = true; break;
        }

        string notADigit = "not a digit";
        Console.WriteLine("{0}", isNotDigit == true ? notADigit : digitToWord);
    }
}
