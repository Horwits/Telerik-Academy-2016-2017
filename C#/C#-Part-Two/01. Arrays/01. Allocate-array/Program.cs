﻿using System;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = 5 * i;
            Console.WriteLine(array[i]);
        }
    }
}
