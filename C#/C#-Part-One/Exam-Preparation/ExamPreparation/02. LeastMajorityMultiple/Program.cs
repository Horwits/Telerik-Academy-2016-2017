using System;

class Program
{
    static void Main()
    {
        checked
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            byte d = byte.Parse(Console.ReadLine());
            byte e = byte.Parse(Console.ReadLine());

            decimal product = a * b * c * d;

            int counter = 0;
            for (int i = 1; i < product; i++)
            {
                if (i % a == 0)
                {
                    counter++;
                }
                if (i % b == 0)
                {
                    counter++;
                }
                if (i % c == 0)
                {
                    counter++;
                }
                if (i % d == 0)
                {
                    counter++;
                }
                if (i % e == 0)
                {
                    counter++;
                }

                if (counter >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    counter = 0;
                }
            }
        }
    }
}
