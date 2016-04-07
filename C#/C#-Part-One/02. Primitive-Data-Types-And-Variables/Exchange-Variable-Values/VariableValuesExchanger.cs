using System;

class VariableValuesExchanger
{
    static void Main()
    {
        /*Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
        Print the variable values before and after the exchange.*/

        int a = 5;
        int b = 10;

        Console.WriteLine("Before:{1}a = {0}{1}b = {2}{1}", a, "\n\r", b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After: {1}a = {0}{1}b = {2}", a, "\n\r", b);
    }
}
