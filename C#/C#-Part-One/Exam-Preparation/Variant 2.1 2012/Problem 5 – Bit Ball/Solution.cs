using System;
using System.IO;

//TODO : FIX


class Solution
{
    static void Main()
    {
        //using (var reader = new StreamReader(@"..\..\test.txt"))
        //{
            var firstTeam = new byte[8];
            var secondTeam = new byte[8];

            for (int i = 0; i < 16; i++)
            {
                //byte currentLineNumber = byte.Parse(reader.ReadLine());

                byte currentLineNumber = byte.Parse(Console.ReadLine());
                if (i < 8)
                {
                    firstTeam[i] = currentLineNumber;
                }
                else
                {
                    secondTeam[i - 8] = currentLineNumber;
                }
            }


            int firstTeamScore = 0;

            int secondTeamScore = 0;

            for (int line = 0; line < 8; line++)
            {
                for (int cell = 0; cell < 8; cell++)
                {
                    bool isSecondTeamPlayerOnPosition = (secondTeam[line] & (1 << cell)) != 0;

                    if (isSecondTeamPlayerOnPosition)
                    {
                        bool isFirstTeamPlayerOnPosition = (firstTeam[line] & (1 << cell)) != 0;

                        //fouls
                        if (isFirstTeamPlayerOnPosition)
                        {
                            secondTeam[line] = (byte)(secondTeam[line] & ~(1 << cell));
                            firstTeam[line] = (byte)(firstTeam[line] & ~(1 << cell));
                        }
                    }
                }
            }

            for (int line = 0; line < 8; line++)
            {
                for (int cell = 0; cell < 8; cell++)
                {
                    bool isSecondTeamPlayerOnPosition = (secondTeam[line] & (1 << cell)) != 0;
                    bool isFirstTeamPlayerOnPosition = (firstTeam[line] & (1 << cell)) != 0;

                    if (isFirstTeamPlayerOnPosition)
                    {
                        int counter = 1;

                        bool isPathEmpty = true;
                        if (line + 1 < 8)
                        {
                            isPathEmpty = ((firstTeam[line + counter] & (1 << cell)) == 0) && ((secondTeam[line + counter] & (1 << cell)) == 0);
                        }

                        while (line + counter < 8 && isPathEmpty == true)
                        {
                            isPathEmpty = ((firstTeam[line + counter] & (1 << cell)) == 0) && ((secondTeam[line + counter] & (1 << cell)) == 0);
                            counter++;
                        }

                        counter--;
                        if (counter + line == 7)
                        {
                            bool isPositionEmpty = ((firstTeam[7] & (1 << cell)) == 0) && ((secondTeam[7] & (1 << cell)) == 0);

                            if (isPositionEmpty)
                            {
                                firstTeamScore++;
                            }
                        }
                    }

                    if (isSecondTeamPlayerOnPosition)
                    {
                        int counter = 1;

                        bool isPathEmpty = true;
                        if (line - 1 >= 0)
                        {
                            isPathEmpty = ((firstTeam[line - counter] & (1 << cell)) == 0) && ((secondTeam[line - counter] & (1 << cell)) == 0);
                        }

                        while (line - counter >= 0 && isPathEmpty == true)
                        {
                            isPathEmpty = ((firstTeam[line - counter] & (1 << cell)) == 0) && ((secondTeam[line - counter] & (1 << cell)) == 0);
                            counter++;
                        }

                        counter--;
                        if (counter - line == 0)
                        {
                            bool isPositionEmpty = ((firstTeam[0] & (1 << cell)) == 0) && ((secondTeam[0] & (1 << cell)) == 0);

                            if (isPositionEmpty)
                            {
                                secondTeamScore++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("{0}:{1}", firstTeamScore, secondTeamScore);
        }
    //}
}
