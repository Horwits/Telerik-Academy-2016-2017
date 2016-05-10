using System;
using System.Text;

class BinaryToHexConverter
{
    //static string ConvertBinaryToHex(string binaryInput)
    //{
    //    if (binaryInput.Length < 8)
    //    {
    //        binaryInput = binaryInput.PadLeft(8, '0');
    //    }

    //    var hexResult = new StringBuilder();

    //    int length = binaryInput.Length;

    //    for (int i = 0; i < length; i += 4)
    //    {
    //        string currentBin = binaryInput.Substring(i, 4);
    //        switch (currentBin)
    //        {
    //            case "0000":
    //                hexResult.Append("0");
    //                break;
    //            case "0001":
    //                hexResult.Append("1");
    //                break;
    //            case "0010":
    //                hexResult.Append("2");
    //                break;
    //            case "0011":
    //                hexResult.Append("3");
    //                break;
    //            case "0100":
    //                hexResult.Append("4");
    //                break;
    //            case "0101":
    //                hexResult.Append("5");
    //                break;
    //            case "0110":
    //                hexResult.Append("6");
    //                break;
    //            case "0111":
    //                hexResult.Append("7");
    //                break;
    //            case "1000":
    //                hexResult.Append("8");
    //                break;
    //            case "1001":
    //                hexResult.Append("9");
    //                break;
    //            case "1010":
    //                hexResult.Append("A");
    //                break;
    //            case "1011":
    //                hexResult.Append("B");
    //                break;
    //            case "1100":
    //                hexResult.Append("C");
    //                break;
    //            case "1101":
    //                hexResult.Append("D");
    //                break;
    //            case "1110":
    //                hexResult.Append("E");
    //                break;
    //            case "1111":
    //                hexResult.Append("F");
    //                break;
    //        }
    //    }

    //    return hexResult.ToString();
    //}

    //public static string BinaryStringToHexString(string binary)
    //{
    //    StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

    //    // TODO: check all 1's or 0's... Will throw otherwise

    //    int mod4Len = binary.Length % 8;
    //    if (mod4Len != 0)
    //    {
    //        // pad to length multiple of 8
    //        binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
    //    }

    //    for (int i = 0; i < binary.Length; i += 8)
    //    {
    //        string eightBits = binary.Substring(i, 8);
    //        result.AppendFormat("{0:X}", Convert.ToByte(eightBits, 2));
    //    }

    //    return result.ToString();
    //}

    static string HexConverted(string strBinary)
    {
        string strHex = Convert.ToInt64(strBinary, 2).ToString("X");
        return strHex;
    }

    static void Main()
    {
        string bin = Console.ReadLine();
        Console.WriteLine(HexConverted(bin));
    }
}
