using System;
using System.Text;

class BinaryShortGenerator
{
	//TODO: Signed solution fix
    static string ReverseString(string input)
    {
        int length = input.Length;
        var result = new StringBuilder();
        for (int i = length - 1; i >= 0; i--)
        {
            result.Append(input[i]);
        }

        return result.ToString();
    }

    static void Main()
    {
        short n = short.Parse(Console.ReadLine());
        var copyN = n;

        var binaryResult = new StringBuilder();
        while (copyN != 0)
        {
            int digit = copyN % 2;
            copyN /= 2;

            if (n < 0)
            {
                if (digit == -1)
                {
                    binaryResult.Append(0);
                }
                else
                {
                    binaryResult.Append(1);
                }

            }
            else
            {
                binaryResult.Append(digit);
            }
        }

        if (n < 0)
        {
            int length = binaryResult.Length;
            binaryResult = binaryResult.Remove(0, 1);

            string revertedResult = binaryResult.ToString();

            Console.WriteLine(ReverseString(revertedResult) + '1');
        }
        else
        {
            string revertedResult = binaryResult.ToString();
            Console.WriteLine(ReverseString(revertedResult).PadLeft(16, '0'));
        }
    }
}
