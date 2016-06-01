using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PascalTriangle
{
    static void Main()
    {
        /*
         1
         1 1
         1 2 1
         1 3 3 1
         1 4 6 4 1
         1 5 10 10 5 1
         1 6 15 20 15 6 1
         1 7 21 35 35 21 7 1
         */

        int n = 8;

        int[][] pascalTriangle = new int[n][];

        for (int rows = 0; rows < n; rows++)
        {
            pascalTriangle[rows] = new int[rows + 1];
            pascalTriangle[rows][0] = 1;
            pascalTriangle[rows][rows] = 1;
            for (int cols = 1; cols < rows; cols++)
            {
                pascalTriangle[rows][cols] = pascalTriangle[rows - 1][cols - 1] + pascalTriangle[rows - 1][cols];
            }
        }

        for (int rows = 0; rows < n; rows++)
        {
            Console.WriteLine(string.Join(" ", pascalTriangle[rows]));
        }
    }
}
