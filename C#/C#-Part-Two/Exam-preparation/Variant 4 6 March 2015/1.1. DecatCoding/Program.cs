using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static string[] elements;
    static string allLetters = "abcdefghijklmnopqrstuvwxyz";
    static List<string> result = new List<string>();

    public static void ReadRowOfStrings()
    {
        elements = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

    static BigInteger Convertion(string item)
    {
        BigInteger result = 0;

        result += BaseToDecimal(item, allLetters, 21);

        return result;
    }

    static BigInteger BaseToDecimal(string twentyOneBased, string allLetters, int baseNum)
    {
        BigInteger sum = 0;

        foreach (char digit in twentyOneBased)
        {
            var currentPos = allLetters.IndexOf(digit);
            sum = (currentPos) + sum * baseNum;
        }

        return sum;
    }

    static void Solution()
    {
        foreach (var item in elements)
        {
            var twentyOneToDec = Convertion(item);
            var res = ConvertDecimalToTwentySix(twentyOneToDec);
            result.Add(res);
        }

        Console.WriteLine(string.Join(" ", result));
    }

    static string ConvertDecimalToTwentySix(BigInteger number)
    {
        var result = string.Empty;
        while (number != 0)
        {
            int currentDigit = (int)(number % 26);

            result = (char)(currentDigit + 'a') + result;

            number /= 26;
        }

        return result;
    }

    static void Main(string[] args)
    {
        ReadRowOfStrings();
        Solution();
    }
}
