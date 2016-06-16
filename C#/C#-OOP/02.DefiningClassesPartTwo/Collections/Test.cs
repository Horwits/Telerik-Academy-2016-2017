namespace Collections
{
    using System;
    using Collections.Models;

    internal class Test
    {
        internal static void Main(string[] args)
        {
            var m1 = new Matrix<int>(5, 5);
            var m2 = new Matrix<int>(5, 5);

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    m1[r, c] = ((r - c) + 1) * 4;
                    m2[r, c] = ((c + 2) + r) * 3;
                }
            }

            Console.WriteLine("indexing");
            m1[0, 4] = 5;
            Console.WriteLine(m1[0, 4]);
            Console.Write(Environment.NewLine);

            Console.WriteLine("m1 print");
            Console.WriteLine(m1.ToString());
            Console.Write(Environment.NewLine);

            Console.WriteLine("m2 print");
            Console.WriteLine(m2.ToString());
            Console.Write(Environment.NewLine);

            Console.WriteLine("* operator");
            Console.WriteLine((m1 * m2).ToString());
            Console.Write(Environment.NewLine);

            Console.WriteLine("+ operator");
            Console.WriteLine((m1 + m2).ToString());
            Console.Write(Environment.NewLine);

            Console.WriteLine("- operator");
            Console.WriteLine((m1 - m2).ToString());
            Console.Write(Environment.NewLine);

            Console.WriteLine("true and false operators");
            if (m1)
            {
                Console.WriteLine("Doesn't contain zeroes.");
            }
            else
            {
                Console.WriteLine("Contains zeroes.");
            }
        }
    }
}
