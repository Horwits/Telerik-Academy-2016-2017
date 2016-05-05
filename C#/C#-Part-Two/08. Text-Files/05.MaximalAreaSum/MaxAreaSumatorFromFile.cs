using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class MaxAreaSumatorFromFile
{
    public static List<string> GetTextFromTextFile(StreamReader reader)
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

    public static void AddTextToTextFile(List<string> input, string filePath)
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

    public static decimal FindBestSubsequence(IEnumerable<decimal> source)
    {
        decimal result = decimal.MinValue;
        decimal sum = 0;
        int tempStart = 0;

        List<decimal> tempList = new List<decimal>(source);

        int startIndex = 0;
        int endIndex = 0;

        for (int index = 0; index < tempList.Count; index++)
        {
            sum += tempList[index];
            if (sum > result)
            {
                result = sum;
                startIndex = tempStart;
                endIndex = index;
            }
            if (sum < 0)
            {
                sum = 0;
                tempStart = index + 1;
            }
        }

        return result;
    }

    public static int[,] ReadMatrixFromFile(StreamReader matrixProvider)
    {
        using (matrixProvider)
        {
            int matrixLength = int.Parse(matrixProvider.ReadLine());

            var matrix = new int[matrixLength, matrixLength];

            for (int i = 0; i < matrixLength; i++)
            {
                var currentLine = matrixProvider.ReadLine().Split(' ');
                for (int j = 0; j < currentLine.Length; j++)
                {
                    if (currentLine[j] != string.Empty)
                    {
                        matrix[i, j] = int.Parse(currentLine[j]);
                    }
                }
            }

            return matrix;
        }
    }

    static void Main()
    {
        var reader = new StreamReader(@"../../input.txt");

        var matrix = ReadMatrixFromFile(reader);
        reader.Close();

        var writer = new StreamWriter(@"../../input.txt");
        using (writer)
        {

        }
    }
}
