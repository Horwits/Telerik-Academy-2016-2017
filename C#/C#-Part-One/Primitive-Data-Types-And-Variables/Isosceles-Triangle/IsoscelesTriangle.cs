using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        /*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:*/

        Console.OutputEncoding = Encoding.UTF8;

        char test = '\u00A9';

        Console.WriteLine("{0}{0}{0}{1}{0}{0}{2}", ' ', test, "\n\r");
        Console.WriteLine("{0}{0}{1}{0}{1}{2}", ' ', test, "\n\r");
        Console.WriteLine("{0}{1}{0}{0}{0}{1}{2}", ' ', test, "\n\r");
        Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}{1}", test, ' ');
    }
}
