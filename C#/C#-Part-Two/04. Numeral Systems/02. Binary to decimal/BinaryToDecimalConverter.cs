using System;

class BinaryToDecimalConverter
{
    static long BinaryToDecimal(string binary)
    {
        long sum = 0;

        foreach (char bit in binary)
        {
            sum = (bit - '0') + sum * 2;
        }

        return sum;
    }


    //static long ConvertBinaryToDecimal(string binary)
    //{
    //    int currentPosition = 0,
    //        length = binary.Length;
    //
    //    long decimalRepresentation = 0;
    //    for (int i = length - 1; i >= 0; i--)
    //    {
    //        int currentDigit = binary[i] - '0';
    //        decimalRepresentation += (currentDigit * (long)Math.Pow(2, currentPosition));
    //        currentPosition++;
    //    }
    //
    //    return decimalRepresentation;
    //}

    static void Main()
    {
        string binary = Console.ReadLine();

        //var result = ConvertBinaryToDecimal(binary);
        var result = BinaryToDecimal(binary);
        Console.WriteLine(result);
    }
}
