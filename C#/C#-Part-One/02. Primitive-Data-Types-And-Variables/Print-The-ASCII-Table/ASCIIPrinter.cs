using System;

class ASCIIPrinter
{
    static void Main()
    {
        //Console.OutputEncoding = Encoding.ASCII;

        byte asciiLength = 126;

        for (byte i = 33; i <= asciiLength; i++)
        {
            char value = (char)i;
            Console.Write("{0} ", value);
        }
    }
}
