using System;

class NumComparer
{
    static void Main()
    {
        /*Write a program that gets two numbers from the console and prints the greater of them.
        Try to implement this without if statements.*/

        //while (true)
        //{
        var inputA = Console.ReadLine();

        var inputB = Console.ReadLine();

        double a;
        bool inputAIsValid = double.TryParse(inputA, out a);

        double b;
        bool inputBIsValid = double.TryParse(inputB, out b);

        if (inputAIsValid && inputBIsValid)
        {
            Console.WriteLine("{0}", a > b ? a : b);
        }
        else
        {
            string errorMessage = "Wrong input. Try again.";
            Console.WriteLine(errorMessage);
        }

        /*Console.WriteLine("Do you want to quit? y/n");
        var quitButton = Console.ReadKey();

        Console.WriteLine(Environment.NewLine);

        if (quitButton.KeyChar == 'Y' || quitButton.KeyChar == 'y')
        {
            break;
        }*/
        //}
    }
}
