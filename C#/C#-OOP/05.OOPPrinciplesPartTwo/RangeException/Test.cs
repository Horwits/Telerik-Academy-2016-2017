namespace RangeException
{
    using System;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Int test: ");

                throw new InvalidRangeException<int>("Invalid input!", 2, 50);
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ire.Message);
            }

            Console.Write(Environment.NewLine);

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DateTime test: ");

                throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1981, 1, 1), new DateTime(2013, 12, 31));
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ire.Message);
            }
        }
    }
}
