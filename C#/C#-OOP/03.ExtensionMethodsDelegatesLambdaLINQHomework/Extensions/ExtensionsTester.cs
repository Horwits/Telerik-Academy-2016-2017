namespace Extensions
{
    using System;
    using System.Collections.Generic;
    using Extensions.StringBuilder;
    using Extensions.IEnum;

    internal class ExtensionsTester
    {
        internal static void Main(string[] args)
        {
            var text = new System.Text.StringBuilder("Hello world!");
            Console.WriteLine(text);

            Console.WriteLine("Substring");
            var hello = text.Substring(0, 5);
            Console.WriteLine(hello);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Working collection");
            var collection = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            Console.WriteLine(string.Join(" ", collection));
            Console.Write(Environment.NewLine);

            Console.WriteLine("Sum");
            var sum = collection.Sum();
            Console.WriteLine(sum);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Product");
            var product = collection.Product();
            Console.WriteLine(product);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Min");
            var min = collection.Min();
            Console.WriteLine(min);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Max");
            var max = collection.Max();
            Console.WriteLine(max);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Average");
            var average = collection.Average();
            Console.WriteLine(average);



        }
    }
}
