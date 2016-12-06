using System;
using LinearDataStructuresHomework.Data.Contracts;

namespace LinearDataStructuresHomework.Data
{
    public class ConsoleReadWriteProvider : IReadWriteProvider
    {
        public string ReadLine()
        {
            var line = Console.ReadLine();
            return line;
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public void WriteLine(double number)
        {
            Console.WriteLine(number);
        }

        public void WriteLine(int number)
        {
            Console.WriteLine(number);
        }

        public void WriteLine(decimal number)
        {
            Console.WriteLine(number);
        }

        public void WriteLine(long number)
        {
            Console.WriteLine(number);
        }
    }
}