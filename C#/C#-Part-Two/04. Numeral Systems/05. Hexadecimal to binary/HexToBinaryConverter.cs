using System;
using System.Text;

class HexToBinaryConverter
{
    static string ConvertHexToBinary(string input)
    {
        string[] Nybbles =
            {
                "0000", "0001", "0010", "0011",
                "0100", "0101", "0110", "0111",
                "1000", "1001", "1010", "1011",
                "1100", "1101", "1110", "1111"
            };

        StringBuilder result = new StringBuilder(input.Length * 4);
        foreach (char c in input)
        {
            if (c >= '0' && c <= '9')
            {
                result.Append(Nybbles[c - '0']);
            }
            else if (c >= 'a' && c <= 'f')
            {
                result.Append(Nybbles[c - 'a' + 10]);
            }
            else
            {
                throw new FormatException("Invalid hex digit: " + c);
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        string number = Console.ReadLine().ToLower();
        Console.WriteLine(ConvertHexToBinary(number).TrimStart('0'));
    }
}
