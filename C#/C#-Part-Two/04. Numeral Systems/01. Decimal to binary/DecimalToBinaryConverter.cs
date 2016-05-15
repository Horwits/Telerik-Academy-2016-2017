using System;
using System.Text;

class DecimalToBinaryConverter
{
    static string ConvertDecimalToBinary(long number)
    {
        if (number < 1)
        {
            throw new ArgumentException("Input number.", "Number is less than 1.");
        }

        //var reversedResult = new StringBuilder();
        var result = string.Empty;
        while (number != 0)
        {
            int currentDigit = (int)(number % 2);
            //reversedResult.Append(reversedResult).Append(currentDigit);

            result = currentDigit + result;

            number /= 2;
        }

        //var result = new StringBuilder();
        //
        //int length = reversedResult.Length;
        //for (int i = length - 1; i >= 0; i--)
        //{
        //    result.Append(reversedResult[i]);
        //}
        //
        //return result.ToString();

        //return reversedResult.ToString();

        return result;
    }

    static void Main()
    {
        try
        {
            var number = long.Parse(Console.ReadLine());
            Console.WriteLine(ConvertDecimalToBinary(number));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
