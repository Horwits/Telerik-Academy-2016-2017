using System;

class HexadecimalToDecimalConverter
{
    static void Main()
    {
        /*Using loops write a program that converts a hexadecimal integer number to its decimal form.
        The input is entered as string. The output should be a variable of type long.
        Do not use the built-in .NET functionality.
        Examples:
        
        hexadecimal	decimal
        FE	        254
        1AE3	    6883
        4ED528CBB4	338583669684*/

        string userInput = Console.ReadLine();

        long result = HexToDecimal(userInput);
        Console.WriteLine("{0}", result);
    }

    static long HexToDecimal(string hex)
    {
        long decimalNum = 0, tempDigit = 0;
        int position = hex.Length - 1;
        string hexToUpper = hex.ToUpper();
        foreach (var digit in hexToUpper)
        {
            if (digit >= '0' && digit <= '9')
            {
                tempDigit = digit - '0';
            }
            else if (digit >= 'A' && digit <= 'F')
            {
                tempDigit = digit - 'A' + 10;
            }
            else
            {
                position--;
                continue;
            }

            decimalNum += tempDigit * (long)Math.Pow(16, position);

            position--;
        }

        return decimalNum;
    }
}
