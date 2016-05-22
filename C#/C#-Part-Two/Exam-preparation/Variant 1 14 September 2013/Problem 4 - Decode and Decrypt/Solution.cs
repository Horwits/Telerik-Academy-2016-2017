using System;
using System.Text;

class Solution
{
    const char BaseLetter = 'A';

    static string Decrypt(string cypherText, string cypher)
    {
        StringBuilder messageBuilder = new StringBuilder(cypherText);

        int longer = Math.Max(cypherText.Length, cypher.Length);

        for (int index = 0; index < longer; index++)
        {
            int indexInCypherText = index % cypherText.Length;
            int indexInCypher = index % cypher.Length;

            int charInCypherTextOffset = messageBuilder[indexInCypherText] - BaseLetter;
            int charInCypherOffset = cypher[indexInCypher] - BaseLetter;

            messageBuilder[indexInCypherText] = (char)(BaseLetter + (charInCypherTextOffset ^ charInCypherOffset));
        }

        return messageBuilder.ToString();
    }

    static int[] ExtractCypherLengthAndCypherLengthNumberLength(string messageAndCypher)
    {
        var stringLen = string.Empty;
        for (int i = messageAndCypher.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(messageAndCypher[i]))
            {
                stringLen = messageAndCypher[i] + stringLen;
            }
            else
            {
                break;
            }
        }

        int length = int.Parse(stringLen);

        var lengthAndNeededSymbolsRemoved = new int[2];
        lengthAndNeededSymbolsRemoved[0] = length;
        lengthAndNeededSymbolsRemoved[1] = stringLen.Length;

        return lengthAndNeededSymbolsRemoved;
    }

    static string ExtractCypher(string messageAndCypher)
    {
        int cypherLength = ExtractCypherLengthAndCypherLengthNumberLength(messageAndCypher)[0];
        int cypherLengthNumberLength = ExtractCypherLengthAndCypherLengthNumberLength(messageAndCypher)[1];

        int length = messageAndCypher.Length;
        int firstIndex = length - (cypherLengthNumberLength + cypherLength);
        int count = length - (firstIndex + cypherLengthNumberLength);
        string cypher = messageAndCypher.Substring(firstIndex, count);

        return cypher;
    }

    static string[] Decode(string text)
    {
        int cypherLengthNumberLength = ExtractCypherLengthAndCypherLengthNumberLength(text)[1];
        int getCurrLen = 0;
        int length = text.Length;
        var result = new StringBuilder();
        var currentSymbolLength = new StringBuilder();

        bool isNumber = false;
        for (int i = 0; i < length - cypherLengthNumberLength; i++)
        {
            char symbol = text[i];

            if (char.IsDigit(symbol))
            {
                if (i + 1 < length)
                {
                    char nextSymbol = text[i + 1];

                    if (char.IsDigit(nextSymbol))
                    {
                        currentSymbolLength.Append(symbol);
                        isNumber = true;
                    }
                    else if (!char.IsDigit(nextSymbol) && char.IsDigit(symbol))
                    {
                        currentSymbolLength.Append(symbol);
                        getCurrLen = int.Parse(currentSymbolLength.ToString());
                        currentSymbolLength.Clear();
                        isNumber = false;
                    }

                    if (!isNumber)
                    {
                        result.Append(new string(nextSymbol, getCurrLen));
                        i++;
                    }
                }
            }
            else
            {
                result.Append(symbol);
                isNumber = false;
            }
        }

        int cypehrLength = ExtractCypherLengthAndCypherLengthNumberLength(text)[0];
        string cypher = ExtractCypher(result.ToString() + cypehrLength);
        string message = result.ToString().Substring(0, result.Length - (cypher.Length + cypherLengthNumberLength) + 1);

        var messageAndCypher = new string[2];
        messageAndCypher[0] = message;
        messageAndCypher[1] = cypher;

        return messageAndCypher;
    }

    static void Main()
    {
        string text = Console.ReadLine();

        var mesAndCyph = Decode(text);

        string message = mesAndCyph[0];
        string cypher = mesAndCyph[1];

        Console.WriteLine(Decrypt(message, cypher));
    }
}
