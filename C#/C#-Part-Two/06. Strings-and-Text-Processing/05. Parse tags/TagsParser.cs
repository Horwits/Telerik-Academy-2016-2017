using System;
using System.Linq;
using System.Text;

class TagsParser
{
    static void Solution(string text)
    {
        var openTag = "upcase";
        var closeTag = "/upcase";

        var toParse = text
            .Split(new char[] { '<', '>' })
            .ToArray();

        var output = new StringBuilder();
        var toUpper = false;

        foreach (var word in toParse)
        {
            if (word == openTag)
            {
                toUpper = true;
                continue;
            }

            if (word == closeTag)
            {
                toUpper = false;
                continue;
            }

            if (toUpper)
            {
                output.Append(word.ToUpper());
            }
            else
            {
                output.Append(word);
            }
        }

        Console.WriteLine(output);
    }


    /*static string RemoveTagsAndExecuteThem(string text)
    {
        var result = new StringBuilder(text);

        string openTagPattern = "<upcase>";
        string closeTagPattern = "</upcase>";

        int indexCloseTag = text.IndexOf(closeTagPattern),
        indexOpenTag = text.IndexOf(openTagPattern);

        while (indexOpenTag != -1 && indexCloseTag != -1)
        {
            var sub = result.ToString().Substring(indexOpenTag + openTagPattern.Length, indexCloseTag - (indexOpenTag + openTagPattern.Length));
            result.Replace(sub, sub.ToUpper());

            result.Remove(indexOpenTag, openTagPattern.Length);
            result.Remove(indexCloseTag - openTagPattern.Length, closeTagPattern.Length);

            if (indexCloseTag > result.Length)
            {
                indexCloseTag = -1;
            }
            else
            {
                indexCloseTag = result.ToString().IndexOf(closeTagPattern, indexCloseTag + 1);
            }

            if (indexOpenTag > result.Length)
            {
                indexOpenTag = -1;
            }
            else
            {
                indexOpenTag = result.ToString().IndexOf(openTagPattern, indexOpenTag + 1);
            }
        }

        return result.ToString();
    }*/

    static void Main()
    {
        string text = Console.ReadLine();
        Solution(text);
    }
}
