using System;
using System.Text;
using System.IO;

class WarheadSolution
{
    static int CountCapacitorsInRedSection(StringBuilder[] board)
    {
        int capacitors = 0;

        for (int line = 0; line < 16; line++)
        {
            for (int cell = 0; cell < 9; cell++)
            {
                if (line + 2 < 16 && cell + 2 < 9)
                {
                    bool isCapacitor = (board[line][cell] == '1' && board[line][cell + 1] == '1' && board[line][cell + 2] == '1') &&
                        (board[line + 1][cell] == '1' && board[line + 1][cell + 1] == '0' && board[line + 1][cell + 2] == '1') &&
                        (board[line + 2][cell] == '1' && board[line + 2][cell + 1] == '1' && board[line + 2][cell + 2] == '1');

                    if (isCapacitor)
                    {
                        capacitors++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        return capacitors;
    }

    static int CountCapacitorsInBlueSection(StringBuilder[] board)
    {
        int capacitors = 0;

        for (int line = 0; line < 16; line++)
        {
            for (int cell = 8; cell < 16; cell++)
            {
                if (line + 2 < 16 && cell + 2 < 16)
                {
                    bool isCapacitor = (board[line][cell] == '1' && board[line][cell + 1] == '1' && board[line][cell + 2] == '1') &&
                        (board[line + 1][cell] == '1' && board[line + 1][cell + 1] == '0' && board[line + 1][cell + 2] == '1') &&
                        (board[line + 2][cell] == '1' && board[line + 2][cell + 1] == '1' && board[line + 2][cell + 2] == '1');

                    if (isCapacitor)
                    {
                        capacitors++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        return capacitors;
    }

    static int CountCapacitorsInWholeBoard(StringBuilder[] board)
    {
        int counter = 0;

        for (int line = 0; line < 16; line++)
        {
            for (int cell = 0; cell < 16; cell++)
            {
                if (line + 2 < 16 && cell + 2 < 16)
                {
                    bool isCapacitor = (board[line][cell] == '1' && board[line][cell + 1] == '1' && board[line][cell + 2] == '1') &&
                        (board[line + 1][cell] == '1' && board[line + 1][cell + 1] == '0' && board[line + 1][cell + 2] == '1') &&
                        (board[line + 2][cell] == '1' && board[line + 2][cell + 1] == '1' && board[line + 2][cell + 2] == '1');

                    if (isCapacitor)
                    {
                        counter++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        return counter;
    }

    static void RemoveCapacitors(StringBuilder[] board, byte line, byte cell)
    {
        if (line - 1 >= 0 && line + 1 < 16 && cell - 1 >= 0 && cell + 1 < 16)
        {
            bool isCapacitor = (board[line][cell] == '0' && board[line][cell + 1] == '1' && board[line][cell - 1] == '1') &&
                (board[line + 1][cell] == '1' && board[line + 1][cell + 1] == '1' && board[line + 1][cell - 1] == '1') &&
                (board[line - 1][cell] == '1' && board[line - 1][cell + 1] == '1' && board[line - 1][cell - 1] == '1');

            if (isCapacitor)
            {
                board[line][cell + 1] = '0';
                board[line][cell - 1] = '0';
                board[line + 1][cell] = '0';
                board[line + 1][cell + 1] = '0';
                board[line + 1][cell - 1] = '0';
                board[line - 1][cell] = '0';
                board[line - 1][cell + 1] = '0';
                board[line - 1][cell - 1] = '0';
            }
        }
    }

    static void Main()
    {
        //var reader = new StreamReader(@"../../text.txt");

        //using (reader)
        //{
        StringBuilder[] board = new StringBuilder[16];

        for (int i = 0; i < 16; i++)
        {
            board[i] = new StringBuilder();
            //board[i].Append(reader.ReadLine());
            board[i].Append(Console.ReadLine());
        }

        while (true)
        {
            var command = Console.ReadLine();
            //var command = reader.ReadLine();

            if (command == "cut")
            {
                var wire = Console.ReadLine();
                //var wire = reader.ReadLine();

                int redCapacitors = CountCapacitorsInRedSection(board);
                int blueCapacitors = CountCapacitorsInBlueSection(board);

                if (wire == "red" || wire == "left")
                {
                    if (redCapacitors > 0)
                    {
                        Console.WriteLine(redCapacitors);
                        Console.WriteLine("BOOM");
                    }
                    else
                    {
                        Console.WriteLine(blueCapacitors);
                        Console.WriteLine("disarmed");
                    }

                }
                else if (wire == "blue" || wire == "left")
                {
                    if (blueCapacitors > 0)
                    {
                        Console.WriteLine(blueCapacitors);
                        Console.WriteLine("BOOM");
                    }
                    else
                    {
                        Console.WriteLine(redCapacitors);
                        Console.WriteLine("disarmed");
                    }
                }

                break;
            }

            byte line = byte.Parse(Console.ReadLine());
            byte cell = byte.Parse(Console.ReadLine());
            // byte line = byte.Parse(reader.ReadLine());
            // byte cell = byte.Parse(reader.ReadLine());

            var currentLocationValue = board[line][cell];

            if (command == "hover")
            {
                if (currentLocationValue == '1')
                {
                    Console.WriteLine('*');
                }
                else
                {
                    Console.WriteLine('-');
                }
            }
            else if (command == "operate")
            {
                if (currentLocationValue == '0')
                {
                    RemoveCapacitors(board, line, cell);
                }
                else
                {
                    Console.WriteLine("missed");

                    int capacitors = CountCapacitorsInWholeBoard(board);
                    Console.WriteLine(capacitors);

                    Console.WriteLine("BOOM");
                    break;
                }
            }
        }
    }
}

