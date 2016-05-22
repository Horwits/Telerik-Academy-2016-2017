using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static string[,,] FillMatrix(int X, int Y, int Z)
    {
        string[,,] field = new string[X, Y, Z];

        int counter = 0;
        for (int depth = 0; depth < field.GetLength(2); depth++)
        {
            counter++;
            for (int colls = 0; colls < field.GetLength(0); colls++)
            {
                for (int rows = 0; rows < field.GetLength(1); rows++)
                {
                    field[colls, rows, depth] = counter.ToString();
                }
            }
        }

        return field;
    }

    static void Main()
    {
        using (var reader = new StreamReader(@"..\..\input.txt"))
        {
            var fieldSIzes = reader.ReadLine().Split(' ');

            int X = int.Parse(fieldSIzes[0]);
            int Y = int.Parse(fieldSIzes[1]);
            int Z = int.Parse(fieldSIzes[2]);


            string[,,] field = FillMatrix(X, Y, Z);

            var playerOneDirections = reader.ReadLine();
            var playerTwoDirections = reader.ReadLine();

            var directionsLength = playerOneDirections.Length;

            for (int i = 0; i < directionsLength; i++)
            {
                var playerOneDirection = ' ';
                var playerTwoDirection = ' ';

            }

            Console.WriteLine(field[0, 1, 1]);

        }

    }
}
