using System;

class DecimalToHexConverter
{
    static void Main()
    {
        /*Using loops write a program that converts an integer number to its hexadecimal representation.
        The input is entered as long. The output should be a variable of type string.
        Do not use the built-in .NET functionality.
        Examples:
        
        decimal	        hexadecimal
        254	            FE
        6883	        1AE3
        338583669684	4ED528CBB4*/

        string userInput = Console.ReadLine();

        long number;
        bool userInputIsValid = long.TryParse(userInput, out number);

        if (userInputIsValid)
        {
            string result = ConvertDecimalToHex(number);
            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static string ConvertDecimalToHex(long decimalNum)
    {
        long decimalNumCopy = decimalNum;

        if (decimalNum < 0)
        {
            decimalNum *= -1;
        }

        string hexNumber = string.Empty;
        while (decimalNumCopy != 0)
        {
            long digit = decimalNumCopy % 16;
            if (digit >= 0 && digit <= 9)
            {
                digit += '0';
            }
            else if (digit >= 10 && digit <= 16)
            {
                digit += '7';
            }

            char digitToChar = Convert.ToChar(digit);

            hexNumber = digitToChar + hexNumber;

            decimalNumCopy /= 16;
        }

        if (decimalNum < 0)
        {
            return "-" + hexNumber;
        }

        return hexNumber;
    }
}
