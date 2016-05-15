using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TagsParser
{
    static void Main()
    {
        //string text = "<upcase>Lorem</upcase> ipsum dolor sit amet, consectetur adipiscing elit, sed do <upcase>eiusmod tempor</upcase> incididunt ut labore et dolore <upcase>magna aliqua</upcase>. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure <upcase>dolor</upcase> in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est <upcase>laborum</upcase>.";//Console.ReadLine();

        string text = Console.ReadLine();

        int indexOpenTag = 0,
            indexCloseTag = 0,
            foundOpenTag = text.IndexOf("</", indexOpenTag),
            foundCloseTag = text.IndexOf('>', indexCloseTag);

        string upcase = "<upcase>";
        int upcaseLength = upcase.Length;
        var sbText = new StringBuilder();

        while (foundOpenTag != -1 && foundCloseTag != -1)
        {
            var before = text.Substring(0, foundCloseTag - upcaseLength + 1);
            var sub = text.Substring(foundCloseTag + 1, foundOpenTag - foundCloseTag - 1).ToUpper();
            var after = text.Substring((foundOpenTag + 1) + upcaseLength);

            sbText.Append(before)
                .Append(sub)
                .Append(after);

            text = sbText.ToString();
            sbText.Clear();

            indexOpenTag = foundOpenTag + 1;
            indexCloseTag = foundOpenTag + upcaseLength;

            if (indexOpenTag < text.Length && indexCloseTag < text.Length)
            {
                foundOpenTag = text.IndexOf("</", indexOpenTag);
                foundCloseTag = text.IndexOf('>', indexCloseTag);
            }
            else
            {
                foundOpenTag = -1;
                foundCloseTag = -1;
            }
        }

        Console.WriteLine(text);
    }
}
