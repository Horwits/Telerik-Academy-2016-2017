namespace JustMines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        internal static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] playingField = CreateThePlayingField();
            char[,] playingFieldSymbols = InsertingTheMines();
            int counter = 0;
            bool isDead = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int coll = 0;
            bool isNotDrawed = true;
            const int MaxScore = 35;
            bool isMaxScoreReached = false;

            do
            {
                if (isNotDrawed)
                {
                    Console.WriteLine("Let's play “Mines”. Try your luck finding the fields without mines." +
                    " Command 'top' is showing the rankings, 'restart' starts new game, 'exit' exit from the game!");

                    DrawPlayingFieldToConsole(playingField);

                    isNotDrawed = false;
                }

                Console.Write("Please type row and col : ");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out coll) &&
                        row <= playingField.GetLength(0) && coll <= playingField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Rankings(champions);

                        break;
                    case "restart":
                        playingField = CreateThePlayingField();

                        playingFieldSymbols = InsertingTheMines();

                        DrawPlayingFieldToConsole(playingField);

                        isDead = false;

                        isNotDrawed = false;

                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (playingFieldSymbols[row, coll] != '*')
                        {
                            if (playingFieldSymbols[row, coll] == '-')
                            {
                                ExecuteUsersTurn(playingField, playingFieldSymbols, row, coll);
                                counter++;
                            }

                            if (MaxScore == counter)
                            {
                                isMaxScoreReached = true;
                            }
                            else
                            {
                                DrawPlayingFieldToConsole(playingField);
                            }
                        }
                        else
                        {
                            isDead = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Wrong command.\n");
                        break;
                }

                if (isDead)
                {
                    DrawPlayingFieldToConsole(playingFieldSymbols);

                    Console.Write("\nHrrrrrr! You died heroiclly with {0} score. " + "Write your nickname, please: ", counter);

                    string nickName = Console.ReadLine();

                    Score totalUserScore = new Score(nickName, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(totalUserScore);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < totalUserScore.Points)
                            {
                                champions.Insert(i, totalUserScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));

                    Rankings(champions);

                    playingField = CreateThePlayingField();

                    playingFieldSymbols = InsertingTheMines();

                    counter = 0;

                    isDead = false;

                    isNotDrawed = true;
                }

                if (isMaxScoreReached)
                {
                    Console.WriteLine("\nBRAVOOO! You opened 35 boxes.");

                    DrawPlayingFieldToConsole(playingFieldSymbols);

                    Console.WriteLine("Please, write your nickname: ");

                    string nickname = Console.ReadLine();

                    Score score = new Score(nickname, counter);

                    champions.Add(score);

                    Rankings(champions);

                    playingField = CreateThePlayingField();

                    playingFieldSymbols = InsertingTheMines();

                    counter = 0;

                    isMaxScoreReached = false;

                    isNotDrawed = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("Bye.");
            Console.Read();
        }

        private static void Rankings(List<Score> score)
        {
            Console.WriteLine("\nScore:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, score[i].Name, score[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The Rankings are empty!\n");
            }
        }

        private static void ExecuteUsersTurn(char[,] playingField, char[,] mines, int row, int col)
        {
            char minesCounter = CountingMines(mines, row, col);

            mines[row, col] = minesCounter;

            playingField[row, col] = minesCounter;
        }

        private static void DrawPlayingFieldToConsole(char[,] playingField)
        {
            int row = playingField.GetLength(0);
            int col = playingField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", playingField[i, j]));
                }

                Console.Write("|");

                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateThePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] InsertingTheMines()
        {
            int rows = 5;
            int colls = 10;
            char[,] playingField = new char[rows, colls];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> randomPositionOfMinesList = new List<int>();

            while (randomPositionOfMinesList.Count < 15)
            {
                Random random = new Random();
                int randomPositionOfMines = random.Next(50);

                if (!randomPositionOfMinesList.Contains(randomPositionOfMines))
                {
                    randomPositionOfMinesList.Add(randomPositionOfMines);
                }
            }

            foreach (int position in randomPositionOfMinesList)
            {
                int col = position / colls;
                int row = position % colls;

                if (row == 0 && position != 0)
                {
                    col--;
                    row = colls;
                }
                else
                {
                    row++;
                }

                playingField[col, row - 1] = '*';
            }

            return playingField;
        }

        private static void TotalMines(char[,] playingField)
        {
            int col = playingField.GetLength(0);
            int row = playingField.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (playingField[i, j] != '*')
                    {
                        char total = CountingMines(playingField, i, j);
                        playingField[i, j] = total;
                    }
                }
            }
        }

        private static char CountingMines(char[,] playingField, int row, int col)
        {
            int minesCounter = 0;
            int rows = playingField.GetLength(0);
            int cols = playingField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playingField[row - 1, col] == '*')
                {
                    minesCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (playingField[row + 1, col] == '*')
                {
                    minesCounter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playingField[row, col - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if (col + 1 < cols)
            {
                if (playingField[row, col + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playingField[row - 1, col - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playingField[row - 1, col + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playingField[row + 1, col - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playingField[row + 1, col + 1] == '*')
                {
                    minesCounter++;
                }
            }

            return char.Parse(minesCounter.ToString());
        }
    }
}
