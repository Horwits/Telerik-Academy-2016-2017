using  System;

namespace Math.Compare.Logger
{
    public class ConsoleLogger
    {
        public static void LogWithOneParameter(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogWithOneParameterAndCyanColor(string message) // I know about the Single purpose pattern
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}