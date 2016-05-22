using System;
using System.Numerics;

class Solution
{
    private static string[] tres4Numbers = new string[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

    static string ConvertDecimalToHex(BigInteger decValue)
    {
        // better performance could be achieved by using indexing instead of concatanation
        string result = string.Empty;

        do
        {
            int value = (int)(decValue % 9);
            result = tres4Numbers[value] + result;
            decValue /= 9;

        } while (decValue != 0);

        return result;
    }

    static void Main()
    {
        var sendedNumber = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(ConvertDecimalToHex(sendedNumber));
    }
}
