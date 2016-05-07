using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var result = new List<int>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ');

            int currentX = int.Parse(input[0]);
            string currentPositioning = input[2];
            int currentY = int.Parse(input[3]);

            if (currentPositioning == "before")
            {
                result.Add(currentX);
            }

        }
    }
}
