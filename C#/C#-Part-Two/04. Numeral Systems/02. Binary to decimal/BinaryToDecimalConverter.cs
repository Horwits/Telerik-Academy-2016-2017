using System;

class BinaryToDecimalConverter
{
    static long ConvertBinaryToDecimal(string binary)
    {
        int currentPosition = 0,
            length = binary.Length;

        long decimalRepresentation = 0;
        for (int i = length - 1; i >= 0; i--)
        {
            int currentDigit = binary[i] - '0';
            decimalRepresentation += (currentDigit * (long)Math.Pow(2, currentPosition));
            currentPosition++;
        }

        return decimalRepresentation;
    }

    static void Main()
    {
        string binary = Console.ReadLine();

        var result = ConvertBinaryToDecimal(binary);
        Console.WriteLine(result);
    }
}
