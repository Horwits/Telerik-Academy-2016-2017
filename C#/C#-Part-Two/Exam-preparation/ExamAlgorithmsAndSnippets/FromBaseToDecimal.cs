using System;

public class FromBaseToDecimal
{
    //where base numbers are reprasented by string of letters
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

    static long BinaryToDecimal(string binary)
    {
        long sum = 0;

        foreach (char bit in binary)
        {
            sum = (bit - '0') + sum * 2;
        }

        return sum;
    }
}
