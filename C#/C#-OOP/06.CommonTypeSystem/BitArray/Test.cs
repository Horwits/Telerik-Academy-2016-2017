namespace BitArray
{
    using System;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("toString test: ");

            Console.ForegroundColor = ConsoleColor.White;

            var bitArr = new BitArray64(45ul);
            Console.WriteLine(bitArr);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("== test: ");

            Console.ForegroundColor = ConsoleColor.White;

            var bitArr2 = new BitArray64(45ul);

            Console.WriteLine(bitArr == bitArr2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!= test: ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(bitArr != bitArr2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[] test: ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(bitArr[63]);

            // foreach implementation can be seen at the ToString() method

            // equals implementation can be seen at the == and != operators method
        }
    }
}
