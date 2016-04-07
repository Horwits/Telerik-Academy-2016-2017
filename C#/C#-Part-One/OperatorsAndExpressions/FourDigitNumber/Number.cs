using System;

class Number
{
    static void Main()
    {
        /*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
        Prints on the console the number in reversed order: dcba (in our example 1102).
        Puts the last digit in the first position: dabc (in our example 1201).
        Exchanges the second and the third digits: acbd (in our example 2101).
        The number has always exactly 4 digits and cannot start with 0.*/

        var input = Console.ReadLine();
        int number;
        bool inputIsCorrect = int.TryParse(input, out number);
        bool isStartingWithZero = input[0] == '0';

        if (inputIsCorrect && !isStartingWithZero)
        {
            var sumOfDigits = CalculateSumOfDigitsOfNumber(number);
            Console.WriteLine("{0}", sumOfDigits);

            var reversedNumber = int.Parse(ReverseString(input));
            Console.WriteLine("{0}", reversedNumber.ToString().PadLeft(4, '0'));

            var lastDigitOnFirstPos = PutLastDigitOnFirstPosition(number);
            Console.WriteLine("{0}", lastDigitOnFirstPos);

            var exchangedSecondAndThirdDigit = ExchangeSecondAndThirdDigitOfNumber(number);
            Console.WriteLine("{0}", exchangedSecondAndThirdDigit);
        }
        else
        {
            Console.WriteLine("Please, add a valid 4 digit number!");
        }
    }

    static int CalculateSumOfDigitsOfNumber(int number)
    {
        int sum = 0;
        int copyNumber = number;
        while (copyNumber > 0)
        {
            int digit = copyNumber % 10;
            sum += digit;
            copyNumber /= 10;
        }

        return sum;
    }

    static string ReverseString(string input)
    {
        var length = input.Length;
        var reversed = "";
        for (int i = length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        return reversed;
    }

    static string PutLastDigitOnFirstPosition(int number)
    {
        int lastDigit = number % 10;
        int numberWithoutLastDigit = number / 10;

        string stringResult = lastDigit + "" + numberWithoutLastDigit;

        //var result = int.Parse(stringResult);
        //return result;
        return stringResult;
    }

    static string ExchangeSecondAndThirdDigitOfNumber(int number)
    {
        var digitsOfNumber = number.ToString();

        int firstDigit = int.Parse(digitsOfNumber[0].ToString());
        int secondDigit = int.Parse(digitsOfNumber[1].ToString());
        int thirdDigit = int.Parse(digitsOfNumber[2].ToString());
        int fourthDigit = int.Parse(digitsOfNumber[3].ToString());

        string stringResult = firstDigit + "" + thirdDigit + "" + secondDigit + "" + fourthDigit;

        //var result = int.Parse(stringResult);
        return stringResult;
    }
}
