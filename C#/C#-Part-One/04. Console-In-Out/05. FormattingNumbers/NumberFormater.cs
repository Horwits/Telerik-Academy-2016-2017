using System;

class NumberFormater
{
    static void Main()
    {
        /*Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
        The program then prints them in 4 virtual columns on the console. Each column should have a width of 10     characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.*/

        string inputA = Console.ReadLine();

        string inputB = Console.ReadLine();

        string inputC = Console.ReadLine();

        uint a;
        bool inputAIsValid = (uint.TryParse(inputA, out a)) && a < 500;

        float b;
        bool inputBIsValid = float.TryParse(inputB, out b);

        float c;
        bool inputCIsValid = float.TryParse(inputC, out c);

        if (
            inputAIsValid &&
            inputBIsValid &&
            inputCIsValid
            )
        {
            Console.WriteLine(
                "{0:10} |{1:10}| {2:f2}|{3:f3} |",
                Convert.ToString(a, 16).ToUpper(),
                Convert.ToString((byte)a, 2).PadLeft(10, '0'),
                b,
                c
                );
        }
        else
        {
            string errorMessage = "Invalid input number";
            Console.WriteLine(errorMessage);
        }
    }
}

