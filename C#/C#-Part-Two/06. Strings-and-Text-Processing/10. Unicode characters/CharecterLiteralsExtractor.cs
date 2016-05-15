using System;
using System.Text;

class CharecterLiteralsExtractor
{
    static void Main()
    {
        Encoding utf8 = Encoding.UTF8;

        string text = Console.ReadLine();

        var result = new StringBuilder();
        foreach (var item in text)
        {
            result.AppendFormat("\\u{0:X4} ", (int)item);
        }

        Console.WriteLine(result.ToString().TrimEnd());
    }
}
