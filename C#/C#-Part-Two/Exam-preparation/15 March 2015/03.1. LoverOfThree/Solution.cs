using System;
using System.Linq;

class Solution
{
    static bool ChackIfIsInside(bool[,] field, int row, int col)
    {
        bool rowIsInField = 0 <= row && row < field.GetLength(0);
        bool colIsInField = 0 <= col && col < field.GetLength(1);

        return rowIsInField && colIsInField;
    }

    static void Main()
    {
        var rowAndCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rowsCount = rowAndCol[0];
        int colsCount = rowAndCol[1];

        int n = int.Parse(Console.ReadLine());

        var field = new bool[rowsCount, colsCount];
        int row = rowsCount - 1;
        int col = 0;

        var sum = 0;
        int visitedVal = 0;
        for (int i = 0; i < n; i++)
        {
            var directionAndMoves = Console.ReadLine().Split(' ');

            string direction = directionAndMoves[0];
            int moves = int.Parse(directionAndMoves[1]);

            var deltaRow = direction.Contains("U") ? -1 : 1;
            var deltaCol = direction.Contains("L") ? -1 : 1;

            for (int move = 1; move < moves; move++)
            {
                //my mistake was 
                /*
                 row += deltaRow;
                 col += deltaCol;
                 
                if (ChackIfIsInside(field, row, col))
                {
                    that way it makes 1 itteration less
                 */
                if (ChackIfIsInside(field, row + deltaRow, col + deltaCol))
                {
                    row += deltaRow;
                    col += deltaCol;

                    if (direction == "UR" || direction == "RU")
                    {
                        visitedVal += 6;
                    }
                    else if (direction == "DL" || direction == "LD")
                    {
                        visitedVal -= 6;
                    }

                    if (field[row, col] != true)
                    {
                        sum += visitedVal;
                        field[row, col] = true;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        Console.WriteLine(sum);
    }
}
