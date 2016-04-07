using System;

class VariableDeclaration
{
    static void Main()
    {
        /*Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
        Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/

        checked
        {
            ushort firstNumber = 52130;
            sbyte secondNuumber = -115;
            int thirdNumber = 4825932;
            byte fourthNumber = 97;
            short fifthNumber = -10000;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNuumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
            Console.WriteLine(fifthNumber);
        }
    }
}
