using System;

class BinaryToDecimalConverter
{
    static void Main()
    {
        /*Using loops write a program that converts a binary integer number to its decimal form.
        The input is entered as string. The output should be a variable of type long.
        Do not use the built-in .NET functionality.
        Examples:
        
        binary	decimal
        0	0
        11	3
        1010101010101011	43691
        1110000110000101100101000000	236476736*/

        string binary = Console.ReadLine();

        try
        {
            long result = ConvertBinaryToDecimal(binary);
            Console.WriteLine(result);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }

    private static long ConvertBinaryToDecimal(string binary)
    {
        long result = 0;
        int length = binary.Length;
        for (int i = 0; i < length; i++)
        {
            bool inputIsValid = 
                char.IsDigit(binary[length - i - 1]) &&
                (binary[length - i - 1] == '0' || binary[length - i - 1] == '1');

            if (!inputIsValid)
            {
                throw new FormatException("Invalid number");
            }

            if (binary[length - i - 1] == '0')
            {
                continue;
            }

            result += (long)Math.Pow(2,i);
        }
        return result;
    }
}
