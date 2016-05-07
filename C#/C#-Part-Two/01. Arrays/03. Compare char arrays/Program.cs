using System;

class Program
{
    static string CompareCharArrays(char[]firstArray, char[] secondArray)
    {
        string result = string.Empty;
        if (firstArray.Length > secondArray.Length)
        {
            result =  ">";
        }
        else if(firstArray.Length < secondArray.Length)
        {
            result = "<";
        }
        else
        {
            int length = firstArray.Length;
            for (int i = 0; i < length; i++)
            {
                int currentCharFromOne = firstArray[i] - 'a';
                int currentCharFromTwo = secondArray[i] - 'a';
                if (currentCharFromOne > currentCharFromTwo)
                {
                    result = ">";
                    break;
                }
                else if (currentCharFromOne < currentCharFromTwo)
                {
                    result = "<";
                    break;
                }
                else
                {
                    result = "=";
                }
            }
        }

        return result;
    }

    static void Main()
    {
        string inputOne = Console.ReadLine().ToLower();
        string inputTwo = Console.ReadLine().ToLower();

        var firstArray = inputOne.ToCharArray();
        var secondArray = inputTwo.ToCharArray();

        Console.WriteLine(CompareCharArrays(firstArray,secondArray));

        //Console.WriteLine(string.Join(" ,", firstArray));
    }
}
