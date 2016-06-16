namespace ListOfElements
{
    using System;

    internal class GenericListTest
    {
        internal static void Main(string[] args)
        {
            var list = new GenericList<int>(8);

            Console.WriteLine("add");
            for (int i = 0; i < 10; i++)
            {
                list.Add(i + 1);
            }

            Console.WriteLine(list.ToString());
            Console.Write(Environment.NewLine);

            Console.WriteLine("remove at");
            Console.WriteLine(list.ToString());

            list.RemoveAt(0);

            Console.WriteLine(list.ToString());
            Console.Write(Environment.NewLine);

            Console.WriteLine("indexing");
            Console.WriteLine(list[0]);
            Console.Write(Environment.NewLine);

            Console.WriteLine("max");
            Console.WriteLine(list.Max());
            Console.Write(Environment.NewLine);

            Console.WriteLine("min");
            Console.WriteLine(list.Min());
            Console.Write(Environment.NewLine);

            Console.WriteLine("find");
            Console.WriteLine(list.Find(10));
            Console.Write(Environment.NewLine);

            Console.WriteLine("insert");
            Console.WriteLine(list.ToString());

            list.Insert(1, 10);

            Console.WriteLine(list.ToString());
        }
    }
}
