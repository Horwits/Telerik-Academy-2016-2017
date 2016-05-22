using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static string ExtractCode(StreamReader reader, int length)
    {
        var code = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            code.AppendLine(reader.ReadLine());
        }

        return code.ToString();
    }


    static void Main()
    {
        //every main method is starting with the word static
        //every inner method is starting with . and ends with (
        //they can be stored in List of strings

        //reading the input
        using (var reader = new StreamReader(@"..\..\input.txt"))
        {
            //var rows = int.Parse(Console.ReadLine());
            var rows = int.Parse(reader.ReadLine());

            var code = ExtractCode(reader, rows).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            var output = new StringBuilder();

            var indexOpenBracketCopy = 0;
            bool isInMethod = false;
            for (int i = 0; i < code.Length; i++)
            {
                var currentLine = code[i];
                var nextLine = string.Empty;

                //finding when we are in, and out of some method
                if (i + 1 < code.Length)
                {
                    nextLine = code[i + 1];
                }

                int indexOfOpenBracket = nextLine.IndexOf('{');
                int indexOfStaticWord = currentLine.IndexOf("static");

                if (indexOfOpenBracket != -1 && indexOfStaticWord != -1)
                {
                    var indexOfOpenParametherBracket = currentLine.IndexOf('(');
                    indexOpenBracketCopy = indexOfOpenBracket;
                    var indexOfBeforeNameWhiteSpace = 0;
                    for (int j = indexOfOpenParametherBracket - 1; j >= 0; j--)
                    {
                        if (currentLine[j] == ' ')
                        {
                            indexOfBeforeNameWhiteSpace = j;
                            break;
                        }
                    }

                    string mainName = currentLine.Substring(indexOfBeforeNameWhiteSpace + 1, indexOfOpenParametherBracket - indexOfBeforeNameWhiteSpace - 1);

                    output.Append(mainName).Append(" -> ");
                    isInMethod = true;
                }

                if (isInMethod)
                {
                    var indexOfDot = currentLine.IndexOf('.');
                    var indexOfMethodOpenBracket = -1;//currentLine.IndexOf('(');
                    if (indexOfDot != -1)
                    {
                        indexOfMethodOpenBracket = currentLine.IndexOf('(', indexOfDot);
                    }
                    else if (indexOfStaticWord == -1)
                    {
                        indexOfMethodOpenBracket = currentLine.LastIndexOf('(');

                        int indexOfFirstLetter = 0;
                        for (int k = indexOfMethodOpenBracket - 1; k >= 0; k--)
                        {
                            char currentSymbol = currentLine[k];
                            if (currentSymbol == ' ' || currentSymbol == '(' || k == 0)
                            {
                                indexOfFirstLetter = k + 1;
                                break;
                            }

                            if (!char.IsLetter(currentSymbol))
                            {
                                break;
                            }
                        }

                        if (char.IsLetter(currentLine[indexOfFirstLetter]) && currentLine[indexOfFirstLetter] >= 'A' && currentLine[indexOfFirstLetter] <= 'Z')
                        {
                            string currMethodName = currentLine.Substring(indexOfFirstLetter, indexOfMethodOpenBracket - indexOfFirstLetter);

                            output.AppendFormat("{0}{1}", currMethodName, ", ");
                        }
                    }

                    while (indexOfDot != -1 && indexOfMethodOpenBracket != -1)
                    {
                        string currentMethodName = currentLine.Substring(indexOfDot + 1, indexOfMethodOpenBracket - (indexOfDot + 1));

                        output.AppendFormat("{0}{1}", currentMethodName, ", ");

                        indexOfDot = currentLine.IndexOf('.', indexOfDot + 1);
                        indexOfMethodOpenBracket = currentLine.IndexOf('(', indexOfMethodOpenBracket + 1);
                    }
                }

                int indexOfCloseBracket = nextLine.IndexOf('}');
                if (indexOfCloseBracket != -1 && indexOfCloseBracket == indexOpenBracketCopy)
                {
                    output.Remove(output.Length - 2, (output.Length) - (output.Length - 2));
                    output.AppendLine();
                    isInMethod = false;
                }
            }

            Console.WriteLine(output.ToString().TrimEnd());

            //if you read it line by line ->
            //on currentLine if you have static -> this is the main name of this method
            //this means you are at method -> the next line is the opening bracket so you have to get the position(index)
            //when we are at method , we have to search for LastIndex of ( and to not be static at this row and if we have ..
            //or if we are at the method and the dot is != -1  it's easy 
            //if we have closing bracket and it is on exact same index --> break and appendnewline and shit
        }
    }
}
