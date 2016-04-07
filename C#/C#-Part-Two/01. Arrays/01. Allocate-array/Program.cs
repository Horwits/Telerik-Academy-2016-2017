using System;

class Program
{
    static void PrintArrayOnConsole<T> (T[] collection)
        where T : IComparable
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item.ToString());
        }
    }


    static void Main()
    {
        byte inputNumber = byte.Parse(Console.ReadLine());

        short[] products = new short[inputNumber];
        for (byte i = 0; i < inputNumber; i++)
        {
            products[i] = (short)(i * inputNumber);
        }

        PrintArrayOnConsole(products);
    }
}
