﻿using System;

class Program
{
    static void Main()
    {
        /*Declare two string variables and assign them with Hello and World.
        Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
        Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).*/


        string hello = "Hello";
        string world = "World";

        object concatenated = hello + world;

        string helloWorld = (string)concatenated;//concatenated as string;

        Console.WriteLine(helloWorld);

    }
}