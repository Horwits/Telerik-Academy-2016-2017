using System.Collections.Generic;
using System.IO;

class TextFileUtils
{
    static List<string> GetTextFromTextFile(StreamReader reader)
    {
        var readedLines = new List<string>();
        using (reader)
        {
            var currentLine = string.Empty;
            while (currentLine != null)
            {
                currentLine = reader.ReadLine();
                readedLines.Add(currentLine);
            }
        }

        readedLines.RemoveAt(readedLines.Count - 1);
        return readedLines;
    }

    static void AddTextToTextFile(List<string> input, string filePath)
    {
        if (!File.Exists(filePath))
        {
            using (var outputFile = File.CreateText(filePath))
            {
                foreach (var item in input)
                {
                    outputFile.WriteLine(item);
                }
            }
        }
        else
        {
            var outputFile = new StreamWriter(filePath);
            using (outputFile)
            {
                foreach (var item in input)
                {
                    outputFile.WriteLine(item);
                }
            }
        }
    }

    static void Main()
    {
        var reader = new StreamReader(@"../../input.txt");
        using (reader)
        {
            var readedLines = GetTextFromTextFile(reader);
            readedLines.Sort();

            AddTextToTextFile(readedLines, @"../../output.txt");
        }
    }
}
