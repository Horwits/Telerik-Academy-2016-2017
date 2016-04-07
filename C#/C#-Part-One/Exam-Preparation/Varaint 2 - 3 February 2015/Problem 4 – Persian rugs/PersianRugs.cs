using System;

class PersianRugs
{
    static void Main()
    {
        int n = 5;//int.Parse(Console.ReadLine());
        int d = 10;//int.Parse(Console.ReadLine());

        int canvasWidth = 2 * n + 1,
            canvasHeight = canvasWidth,
            outterDashLength = 0,
            emptyPartLength = canvasWidth - 2;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('#', outterDashLength));
            Console.Write(new string('\\', 1));
            if (d > n)
            {
                Console.Write(new string(' ', emptyPartLength));
                emptyPartLength-=2;
            }
            else
            {

            }

            Console.Write(new string('/', 1));
            Console.WriteLine(new string('#', outterDashLength));

            outterDashLength++;
        }

        //middle row
        Console.Write(new string('#', n));
        Console.Write(new string('X', 1));
        Console.WriteLine(new string('#', n));

        emptyPartLength += 2;
        for (int i = 0; i < n; i++)
        {
            outterDashLength--;

            Console.Write(new string('#', outterDashLength));
            Console.Write(new string('/', 1));
            if (d > n)
            {
                Console.Write(new string(' ', emptyPartLength));
                emptyPartLength += 2;
            }
            else
            {

            }

            Console.Write(new string('\\', 1));
            Console.WriteLine(new string('#', outterDashLength));
        }
    }
}
