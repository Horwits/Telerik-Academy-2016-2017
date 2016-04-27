using System;
using System.Text;

class Program
{
    static void Main()
    {
        string num = Console.ReadLine();

        var result = new StringBuilder();

        for (int i = 0; i < 3; i++)
        {
            int length = num.Length;

            result.Append(num[length - 1]);

            for (int k = 0; k < length - 1; k++)
            {
                result.Append(num[k]);
            }

            if (i < 3)
            {
                int currentNum = int.Parse(result.ToString());
                num = currentNum.ToString();
                result.Clear();
            }
        }

        Console.WriteLine(num);
    }
}
