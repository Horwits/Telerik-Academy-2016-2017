using System;
using System.Text;

class AnchorTagReplacer
{
    static void Main()
    {
        string text = Console.ReadLine();

        string startLinkPattern = "<a href=\"";
        string endLinkPattern = "\">";
        string endTextPattern = "</a>";

        int startLinkIndex = text.IndexOf(startLinkPattern);
        int endLinkIndex = text.IndexOf(endLinkPattern);
        int endTextIndex = text.IndexOf(endTextPattern);

        while (startLinkIndex != -1 && endLinkIndex != -1)
        {
            string currentLink = text.Substring(startLinkIndex + startLinkPattern.Length, endLinkIndex - (startLinkIndex + startLinkPattern.Length));

            string currentText = text.Substring(endLinkIndex + endLinkPattern.Length, endTextIndex - (endLinkIndex + endLinkPattern.Length));

            string beforeLinkText = text.Substring(0, startLinkIndex);

            string afterLinkText = text.Substring(endTextIndex + endTextPattern.Length, text.Length - (endTextIndex + endTextPattern.Length));

            var currentTextModification = new StringBuilder();
            currentTextModification.AppendFormat("{0}[{1}]({2}){3}", beforeLinkText, currentText, currentLink, afterLinkText);

            text = currentTextModification.ToString();
            currentTextModification.Clear();

            startLinkIndex = text.IndexOf(startLinkPattern, startLinkIndex += 1);
            endLinkIndex = text.IndexOf(endLinkPattern, endLinkIndex += 1);
            endTextIndex = text.IndexOf(endTextPattern, endTextIndex += 1);
        }

        Console.WriteLine(text);
    }
}
