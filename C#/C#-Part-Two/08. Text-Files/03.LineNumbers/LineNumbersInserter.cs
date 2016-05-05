using System;
using System.Collections.Generic;
using System.IO;

class LineNumbersInserter
{
    public static List<string> GetFileText(string path)
    {
        List<string> output = new List<string>();
        var input = new StreamReader(path);
        using (input)
        {
            output.AddRange(File.ReadAllLines(path));
        }

        return output;
    }

    static void Main()
    {
        var text = GetFileText(@"../../input.txt");

        var writer = new StreamWriter(@"../../output.txt");
        using (writer)
        {
            var count = text.Count;
            for (int i = 0; i < count; i++)
            {
                writer.WriteLine("{0}. {1}", i + 1, text[i]);
            }
        }
    }
}
