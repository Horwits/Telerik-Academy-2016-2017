using System.Text;
using System.IO;

public class TextFileConcatenator
{
    public TextFileConcatenator(string textFileOnePath, string textFileTwoPath)
    {
        this.TextFileOne = new StreamReader(textFileOnePath);
        this.TextFileTwo = new StreamReader(textFileTwoPath);
    }

    public StreamReader TextFileOne { get; set; }

    public StreamReader TextFileTwo { get; set; }

    public void ConcatenateTwoTextFiles(string outputPath)
    {
        var toBeWrittenIn = new StreamWriter(outputPath);
        using (toBeWrittenIn)
        {
            
            var text1 = this.TextFileOne.ReadToEnd();
            var text2 = this.TextFileTwo.ReadToEnd();

            var output = new StringBuilder();
            output.Append(text1).Append(" ").Append(text2);

            foreach (var symbol in output.ToString())
            {
                toBeWrittenIn.Write(symbol);
            }
        }
    }
}

public class ConcatenationExecuter
{
    static void Main()
    {
        var concatenator = new TextFileConcatenator(@"../../TextFile1.txt", @"../../TextFile2.txt");

        concatenator.ConcatenateTwoTextFiles(@"../../output.txt");
    }
}
