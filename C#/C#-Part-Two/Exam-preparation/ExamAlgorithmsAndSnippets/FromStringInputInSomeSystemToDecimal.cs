using System;

public class FromStringInputWithoutSpacesToDecimalConverter
{
    //Add the numbers like int the example (this is in base 7)
    //when using change the radix with the number of the needed base
    static void Main()
    {
        var digitsToValues = new List<string>();//new Dictionary<string, int>();

        //add the needed numbers as strings
        digitsToValues.Add("f");//, 0);
        digitsToValues.Add("bIN");//, 1);
        digitsToValues.Add("oBJEC");//, 2);
        digitsToValues.Add("mNTRAVL");//, 3);
        digitsToValues.Add("lPVKNQ");//, 4);
        digitsToValues.Add("pNWE");//, 5);
        digitsToValues.Add("hT");//, 6);

        //the text representing the digits
        var numberToConvert = Console.ReadLine();

        int pos = 0;
        int i = 0;

        int length = numberToConvert.Length;
        int breakCounter = 0;

        BigInteger sum = 0;
        var indexOfCurrentDigit = 0;
        var copy = new StringBuilder(numberToConvert);

        //change the radix
        int radix = 7;
        while (true)
        {
            indexOfCurrentDigit = numberToConvert.IndexOf(digitsToValues[i]);

            if (indexOfCurrentDigit == pos)
            {
                //replace the found value with @
                numberToConvert = copy.Replace(digitsToValues[i], "@", pos, digitsToValues[i].Length).ToString();
                breakCounter += digitsToValues[i].Length;
                sum = i + sum * radix;
                pos++;

                i = 0;
            }
            else
            {
                i++;
            }

            if (breakCounter == length)
            {
                break;
            }
        }

        Console.WriteLine(sum);
    }
}
