using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class CharecterLiteralsExtractor
{
    static string EncodeNonAsciiCharacters(string value)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in value)
        {
            // This character is too big for ASCII
            string encodedValue = "\\u" + ((int)c).ToString("x4").ToUpper();
            sb.Append(encodedValue);
        }

        return sb.ToString();
    }

    static void Main()
    {
        CultureInfo currentCulture = Thread.CurrentThread.CurrentUICulture;
        
        string text = Console.ReadLine();

        Console.WriteLine(EncodeNonAsciiCharacters(text));

        //var result = new StringBuilder();
        //foreach (var item in text)
        //{
        //    result.AppendFormat(@"\u{0:X4}", (ushort)item);
        //}
        //
        //Console.WriteLine(result.ToString().TrimEnd());

    }
}
