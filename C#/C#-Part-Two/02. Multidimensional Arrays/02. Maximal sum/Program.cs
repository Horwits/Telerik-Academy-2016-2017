using System;

class Program
{
    static void Main()
    {
        string heightAndWidth = Console.ReadLine();
        var splitted = heightAndWidth.Split(' ');
        int n = int.Parse(splitted[0]);
        int m = int.Parse(splitted[1]);

        decimal sum = 0;
        string[,] matrix = new string[n, m];
        for (int i = 0, j = 0; i < n; i++)
        {
            if (j <= m)
            {
                var input = Console.ReadLine().Split(' ');
                foreach (var item in input)
                {
                    matrix[i, j] = item;
                    sum += int.Parse(item);
                    j++;
                }
            }

            j = 0;
        }

        Console.WriteLine(sum);
    }
}
