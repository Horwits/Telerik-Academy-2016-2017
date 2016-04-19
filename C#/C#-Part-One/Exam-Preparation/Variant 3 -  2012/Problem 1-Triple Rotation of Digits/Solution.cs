using System;
using System.Text;

class Solution
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());

        int copyK = k;

        var digitToStrB = new StringBuilder();

        for (int i = 0; i < 3; i++)
        {
            int lastDigit = copyK % 10;

            digitToStrB.Append(lastDigit).Append(copyK / 10);

            copyK = int.Parse(digitToStrB.ToString());

            if (i != 2)
            {
                digitToStrB.Clear();
            }
        }

        Console.WriteLine(copyK);
    }
}