using System;

class PersianRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int canvasWidth = 2 * n + 1,
            firstPartHeight = n,
            outterDashLength = 0;

        if (d > n)
        {
            int innerEmptySpace = canvasWidth - (outterDashLength + 2);

            for (int i = 0; i < firstPartHeight; i++)
            {
                Console.Write(new string('#', outterDashLength));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', innerEmptySpace));
                Console.Write(new string('/', 1));
                Console.WriteLine(new string('#', outterDashLength));

                innerEmptySpace -= 2;
                outterDashLength++;
            }

            //middle row
            Console.Write(new string('#', n));
            Console.Write(new string('X', 1));
            Console.WriteLine(new string('#', n));

            innerEmptySpace = 1;
            outterDashLength--;

            for (int i = 0; i < firstPartHeight; i++)
            {
                Console.Write(new string('#', outterDashLength));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', innerEmptySpace));
                Console.Write(new string('\\', 1));
                Console.WriteLine(new string('#', outterDashLength));

                innerEmptySpace += 2;
                outterDashLength--;
            }
        }
        else
        {
            int innerEmptySpace = canvasWidth - (outterDashLength + 2),
                innerDots = canvasWidth - (4 + 2 * d);

            for (int i = 0; i < firstPartHeight; i++)
            {
                if (innerDots > 0)
                {
                    Console.Write(new string('#', outterDashLength));
                    Console.Write(new string('\\', 1));
                    Console.Write(new string(' ', d));
                    Console.Write(new string('\\', 1));

                    Console.Write(new string('.', innerDots));

                    Console.Write(new string('/', 1));
                    Console.Write(new string(' ', d));
                    Console.Write(new string('/', 1));
                    Console.WriteLine(new string('#', outterDashLength));
                }
                else
                {
                    Console.Write(new string('#', outterDashLength));
                    Console.Write(new string('\\', 1));
                    Console.Write(new string(' ', innerEmptySpace));
                    Console.Write(new string('/', 1));
                    Console.WriteLine(new string('#', outterDashLength));
                }

                innerDots -= 2; 
                innerEmptySpace -= 2;
                outterDashLength++;
            }

            //middle row
            Console.Write(new string('#', n));
            Console.Write(new string('X', 1));
            Console.WriteLine(new string('#', n));

            outterDashLength--;
            innerEmptySpace = 1;
            innerDots += 2;

            for (int i = 0; i < firstPartHeight; i++)
            {
                if (innerDots > 0)
                {
                    Console.Write(new string('#', outterDashLength));
                    Console.Write(new string('/', 1));
                    Console.Write(new string(' ', d));
                    Console.Write(new string('/', 1));

                    Console.Write(new string('.', innerDots));

                    Console.Write(new string('\\', 1));
                    Console.Write(new string(' ', d));
                    Console.Write(new string('\\', 1));
                    Console.WriteLine(new string('#', outterDashLength));
                }
                else
                {
                    Console.Write(new string('#', outterDashLength));
                    Console.Write(new string('/', 1));
                    Console.Write(new string(' ', innerEmptySpace));
                    Console.Write(new string('\\', 1));
                    Console.WriteLine(new string('#', outterDashLength));
                }

                innerDots += 2;
                innerEmptySpace += 2;
                outterDashLength--;
            }
        }
    }
}
