using System;
using System.Text;

class NumberToWordsGenerator
{
    static void Main()
    {
        /*Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.*/

        while (true)
        {
            Console.WriteLine("If you want to quit the application press 'Q'!");
            Console.WriteLine("Please, write an integer number: ");
            string userInput = Console.ReadLine();

            int number;
            bool isValid = false;
            if (userInput == "q" || userInput == "Q")
            {
                break;
            }
            else
            {
                isValid = int.TryParse(userInput, out number);
            }

            #region Solution
            if (isValid)
            {
                int ones = -1,
                tens = -1,
                hundreds = -1;

                for (int i = 0, copyNumber = number; copyNumber > 0; i++)
                {
                    if (i == 0)
                    {
                        ones = copyNumber % 10;
                    }
                    else if (i == 1)
                    {
                        tens = copyNumber % 10;
                    }
                    else
                    {
                        hundreds = copyNumber % 10;
                    }

                    copyNumber /= 10;
                }

                string hundredsToWord = string.Empty;
                switch (hundreds)
                {
                    case 1: hundredsToWord = "one hundred"; break;
                    case 2: hundredsToWord = "two hundred"; break;
                    case 3: hundredsToWord = "three hundred"; break;
                    case 4: hundredsToWord = "four hundred"; break;
                    case 5: hundredsToWord = "five hundred"; break;
                    case 6: hundredsToWord = "six hundred"; break;
                    case 7: hundredsToWord = "seven hundred"; break;
                    case 8: hundredsToWord = "eight hundred"; break;
                    case 9: hundredsToWord = "nine hundred"; break;
                }

                string tensToWord = string.Empty;
                switch (tens)
                {
                    case 1:
                        if (number == 10)
                        {
                            tensToWord = "ten";
                        }
                        else
                        {
                            switch (ones)
                            {
                                case 1: tensToWord = "eleven"; break;
                                case 2: tensToWord = "twelve"; break;
                                case 3: tensToWord = "thirteen"; break;
                                case 4: tensToWord = "fourteen"; break;
                                case 5: tensToWord = "fifteen"; break;
                                case 6: tensToWord = "sixteen"; break;
                                case 7: tensToWord = "seventeen"; break;
                                case 8: tensToWord = "eighteen"; break;
                                case 9: tensToWord = "nineteen"; break;
                            }
                        }
                        break;
                    case 2: tensToWord = "twenty"; break;
                    case 3: tensToWord = "thirty"; break;
                    case 4: tensToWord = "fourty"; break;
                    case 5: tensToWord = "fifthy"; break;
                    case 6: tensToWord = "sixty"; break;
                    case 7: tensToWord = "seventy"; break;
                    case 8: tensToWord = "eighty"; break;
                    case 9: tensToWord = "ninety"; break;
                }

                string onesToWord = string.Empty;
                if (number == 0)
                {
                    onesToWord = "zero";
                }

                if (tens != 1 && ones != 0)
                {
                    switch (ones)
                    {
                        case 1: onesToWord = "one"; break;
                        case 2: onesToWord = "two"; break;
                        case 3: onesToWord = "three"; break;
                        case 4: onesToWord = "four"; break;
                        case 5: onesToWord = "five"; break;
                        case 6: onesToWord = "six"; break;
                        case 7: onesToWord = "seven"; break;
                        case 8: onesToWord = "eight"; break;
                        case 9: onesToWord = "nine"; break;
                    }
                }

                StringBuilder word = new StringBuilder();
                if (hundredsToWord == string.Empty && tensToWord == string.Empty && onesToWord != string.Empty)
                {
                    word.Append(onesToWord);
                }
                else if (hundredsToWord == string.Empty && tensToWord != string.Empty && onesToWord != string.Empty)
                {
                    word.Append(tensToWord).Append(" ").Append(onesToWord);
                }
                else if (hundredsToWord != string.Empty && tensToWord != string.Empty && onesToWord == string.Empty)
                {
                    word.Append(hundredsToWord).Append(" and ").Append(tensToWord);
                }
                else if (hundredsToWord != string.Empty && tensToWord == string.Empty && onesToWord != string.Empty)
                {
                    word.Append(hundredsToWord).Append(" and ").Append(onesToWord);
                }
                else if (hundredsToWord != string.Empty && tensToWord == string.Empty && onesToWord == string.Empty)
                {
                    word.Append(hundredsToWord);
                }
                else if (hundredsToWord == string.Empty && tensToWord != string.Empty && onesToWord == string.Empty)
                {
                    word.Append(tensToWord);
                }
                else
                {
                    word.Append(hundredsToWord).Append(" and ").Append(tensToWord).Append(" ").Append(onesToWord);
                }

                word[0] = char.ToUpper(word[0]);
                Console.WriteLine(word.ToString());
            }
            #endregion
            else
            {
                Console.WriteLine("Wrong input. Try again.");
            }
        }
    }
}
