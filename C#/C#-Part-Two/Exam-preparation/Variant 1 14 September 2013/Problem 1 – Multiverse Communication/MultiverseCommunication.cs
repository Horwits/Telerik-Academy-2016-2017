using System;
using System.Numerics;
using System.Text;

class MultiverseCommunication
{
    static string ConvertInput(string input)
    {
        var result = new StringBuilder();

        int length = input.Length;
        for (int i = 0; i < length; i += 3)
        {
            var currentString = input.Substring(i, 3);
            switch (currentString)
            {
                case "CHU":
                    result.Append(0);
                    break;
                case "TEL":
                    result.Append(1);
                    break;
                case "OFT":
                    result.Append(2);
                    break;
                case "IVA":
                    result.Append(3);
                    break;
                case "EMY":
                    result.Append(4);
                    break;
                case "VNB":
                    result.Append(5);
                    break;
                case "POQ":
                    result.Append(6);
                    break;
                case "ERI":
                    result.Append(7);
                    break;
                case "CAD":
                    result.Append(8);
                    break;
                case "K-A":
                    result.Append(9);
                    break;
                case "IIA":
                    result.Append('A');
                    break;
                case "YLO":
                    result.Append('B');
                    break;
                case "PLA":
                    result.Append('C');
                    break;
            }
        }

        return result.ToString();
    }

    static BigInteger ConvertFromAnyToDecimal(string number, int currentBase)
    {
        string characters = "0123456789ABCDEF";

        int length = number.Length;
        BigInteger result = 0;
        for (int i = 0; i < length; i++)
        {
            result = result * currentBase + characters.IndexOf(number[i]);
        }

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        var message = ConvertInput(input);
        var result = ConvertFromAnyToDecimal(message, 13);

        Console.WriteLine(result);
    }
}
