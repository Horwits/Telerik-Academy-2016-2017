using System;

class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        int dots = height - 1,
        middle = 0;

        int crossroads = 1,
            crossroadsLevelChange = 2;

        for (int i = 0; i < height; i++)
        {
            Console.Write(new string('.', dots));
            Console.Write(new string('/', 1));

            if (i == crossroads)
            {
                Console.Write(new string('-', middle));
                crossroads += crossroadsLevelChange;
                crossroadsLevelChange++;
            }
            else
            {
                Console.Write(new string('.', middle));
            }

            Console.Write(new string('\\', 1));
            Console.Write(new string('.', dots));

            dots--;
            middle += 2;

            Console.WriteLine();
        }
    }
}
