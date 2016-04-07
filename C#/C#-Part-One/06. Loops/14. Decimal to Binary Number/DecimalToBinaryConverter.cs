using System;
using System.Text;

class DecimalToBinaryConverter
{
    static void Main()
    {
        /*Using loops write a program that converts an integer number to its binary representation.
        The input is entered as long. The output should be a variable of type string.
        Do not use the built-in .NET functionality.
        Examples:
        
        decimal	    binary
        0	        0
        3	        11
        43691	    1010101010101011
        236476736	1110000110000101100101000000*/

        string userInput = Console.ReadLine();

        long number;
        bool userInputIsValid = long.TryParse(userInput, out number);
        if (userInputIsValid)
        {
            string binary = ConvertDecimalToBinary(number);
            Console.WriteLine(binary);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

    private static string ConvertDecimalToBinary(long number)
    {
        StringBuilder reversedResult = new StringBuilder();
        while (number != 0)
        {
            long remainder = number % 2;
            number /= 2;

            reversedResult.Append(remainder);
        }

        StringBuilder regularResult = new StringBuilder();

        string reversedBinary = reversedResult.ToString();
        int length = reversedBinary.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            regularResult.Append(reversedBinary[i]);
        }

        string binaryRepresentation = regularResult.ToString();

        return binaryRepresentation;
    }
}
