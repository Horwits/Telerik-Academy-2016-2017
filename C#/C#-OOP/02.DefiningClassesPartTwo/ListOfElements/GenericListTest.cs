namespace ListOfElements
{
    using System;

    internal class GenericListTest
    {
        internal static void Main(string[] args)
        {
            var list = new GenericList<int>(8);
            
            for (int i = 0; i < 10; i++)
            {
                list.Add(i + 1);
            }

            Console.WriteLine(list.ToString());

            list.RemoveAt(0);

            Console.WriteLine(list.ToString());

            Console.WriteLine(list.Max());

            Console.WriteLine(list.Find(10));
        }
    }
}
