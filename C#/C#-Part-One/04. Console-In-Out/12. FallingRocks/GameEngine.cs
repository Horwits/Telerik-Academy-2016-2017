using System;
using System.Collections.Generic;
using System.Threading;

class GameObject
{
    public int X { get; set; }

    public int Y { get; set; }

    public string GameObjectCharacter { get; set; }

    public ConsoleColor Color { get; set; }
}

class GameEngine
{
    const int GAME_SPEED_EASY = 150;
    const int GAME_SPEED_MEDIUM = 120;
    const int GAME_SPEED_HARD = 100;

    const int PLAYING_FIELD_WIDTH = 20;
    const int PLAYING_FIELD_HEIGHT = 30;
    const int CANVAS_WIDTH = 60;
    const int CANVAS_HEIGHT = 30;

    static void PrintObject(GameObject obj, int objX, int objY)
    {
        Console.SetCursorPosition(objX, objY);
        Console.ForegroundColor = obj.Color;
        Console.Write(obj.GameObjectCharacter);
    }

    static void PrintInfo(string info, int infoX, int infoY)
    {
        Console.SetCursorPosition(infoX, infoY);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(info);
    }

    static int GenerateRandomNumber(int min, int max)
    {
        var result = 0;
        Random randomSizeNumber = new Random();
        for (int i = min; i <= max; i++)
        {
        result = randomSizeNumber.Next(min,max);
        }

        return result;
    }

    static GameObject GenerateGameObject(char[] gameObjChar, int rockSize)
    {
        var rock = new GameObject();
        rock.X = GenerateRandomNumber(0, PLAYING_FIELD_WIDTH - 1);
        rock.Y = 0;

        int currentRockCharNumber = GenerateRandomNumber(0, gameObjChar.Length - 1);
        char currentRockChar = gameObjChar[currentRockCharNumber];

        int currentRockSize = rockSize;
        if (currentRockChar == 'S' || currentRockChar == 'L')
        {
            currentRockSize = 1;
        }

        rock.GameObjectCharacter = new string(currentRockChar, currentRockSize);

        int randomColorInteger = GenerateRandomNumber(1, 14);
        rock.Color = Console.ForegroundColor = (ConsoleColor)randomColorInteger;

        return rock;
    }

    static void Main()
    {
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight = CANVAS_HEIGHT;
        Console.BufferWidth = Console.WindowWidth = CANVAS_WIDTH;

        string nameMessage = "ENTER YOUR NAME: ";
        int nameMessageLength = nameMessage.Length / 2;

        int topPosition = CANVAS_HEIGHT / 2;
        int leftPosition = CANVAS_WIDTH / 2 - nameMessageLength;

        Console.Clear();

        Console.SetCursorPosition(leftPosition, topPosition);

        Console.Write(nameMessage);
        var name = Console.ReadLine();

        int startingPositionX = 10;
        int startingPositionY = Console.BufferHeight - 1;

        char[] possibleRockCharacters = new char[] { '@', '^', '*', 'L', '&', '+', '%', 'S', '$', '#', '!', '.', ';', '-' };

        //L - live ; S - Reduce Speed

        var currentGameSpeed = 0;

        var dwarf = new GameObject();
        dwarf.X = startingPositionX;
        dwarf.Y = startingPositionY;
        dwarf.GameObjectCharacter = "0";
        dwarf.Color = ConsoleColor.Gray;

        PrintObject(dwarf, dwarf.X, dwarf.Y);

        int livesCount = 3;

        int score = 0;

        bool isHitted = false,
            isDead = false;

        var rocks = new List<GameObject>();

        int rocksCounter = 0;
        while (true)
        {
            //game objects
            int currentRockSize = GenerateRandomNumber(1, 4);
            //int chance = GenerateRandomNumber(0, 10);
            rocks.Add(GenerateGameObject(possibleRockCharacters, currentRockSize));

            //int specialGeneratedRandomNumber = (GenerateRandomNumber(0, 4));
            //if (chance == specialGeneratedRandomNumber)
            //{
            //    rocks.Add(GenerateGameObject(specialBonusCharacters, 1));
            //}

            //dwarf movement
            if (Console.KeyAvailable)
            {
                var pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.X < PLAYING_FIELD_WIDTH)
                    {
                        dwarf.X++;
                    }
                }

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.X > 0)
                    {
                        dwarf.X--;
                    }
                }

                //exit key
                if (pressedKey.Key == ConsoleKey.E)
                {
                    Console.WriteLine(Environment.NewLine);
                    Environment.Exit(0);
                }
            }

            //rocks movement
            for (int i = 0; i < rocks.Count; i++)
            {
                //colision detection
                bool rockHasMaxLength = rocks[i].GameObjectCharacter.Length == 3,

                    isPossibleColisionX =
                    (
                        rocks[i].X == dwarf.X ||
                        ((rocks[i].X + rocks[i].GameObjectCharacter.Length - 1) == dwarf.X)
                    ),

                    isPossibleColisionY = rocks[i].Y == dwarf.Y,

                    isPossibleColisionWithBiggestRock =
                    rockHasMaxLength &&
                    (
                        isPossibleColisionX ||
                        ((rocks[i].X + 1) == dwarf.X)
                    ) &&
                        isPossibleColisionY;


                if ((isPossibleColisionX && isPossibleColisionY) || isPossibleColisionWithBiggestRock)
                {
                    isHitted = true;
                    if (isHitted)
                    {
                        bool isLivesBonus = rocks[i].GameObjectCharacter[0] == 'L',
                            isSpeedReduce = rocks[i].GameObjectCharacter[0] == 'S';

                        bool isSpecialCharacter = isLivesBonus || isSpeedReduce;
                        if (isSpecialCharacter)
                        {
                            if (isLivesBonus)
                            {
                                livesCount++;
                            }

                            if (isSpeedReduce)
                            {
                                currentGameSpeed /= 2;
                            }
                        }
                        else
                        {
                            livesCount--;
                            if (livesCount <= 0)
                            {
                                isDead = true;
                                break;
                            }

                            currentGameSpeed = 0;
                            rocks.Clear();
                            break;
                        }
                    }
                    else
                    {
                        isHitted = false;
                    }
                }

                if (rocks[i].X >= 0 && rocks[i].X <= PLAYING_FIELD_WIDTH)
                {
                    if (rocks[i].Y == PLAYING_FIELD_HEIGHT - 1)
                    {
                        rocks[i].Y = 0;
                    }
                    else
                    {
                        rocks[i].Y++;
                    }
                }
            }

            if (isDead)
            {
                string deadMessage = "THE DWARF IS DEAD!";
                int deadMessageLength = deadMessage.Length / 2;

                topPosition = CANVAS_HEIGHT / 2;
                leftPosition = CANVAS_WIDTH / 2 - deadMessageLength;

                Console.Clear();

                Console.SetCursorPosition(leftPosition, topPosition);
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(deadMessage);

                Console.ReadKey();
                break;
            }

            //console elements visualization
            Console.Clear();
            PrintObject(dwarf, dwarf.X, dwarf.Y);

            foreach (var rock in rocks)
            {
                //var currentChar = rock.GameObjectCharacter;
                if (rocksCounter < 30)
                {
                    PrintObject(rock, rock.X, rock.Y);
                }

                rocksCounter = 0;
            }

            PrintInfo("PLAYER INFO", 38, 10);
            PrintInfo("-----------", 38, 11);

            PrintInfo(string.Format("PLAYER NAME: {0}", name), 38, 12);

            PrintInfo(string.Format("LIVES: {0}", livesCount), 38, 13);

            PrintInfo(string.Format("SPEED: {0}", currentGameSpeed), 38, 14);

            PrintInfo(string.Format("POINTS: {0}", score), 38, 15);

            PrintInfo("PRESS 'E' TO EXIT!", 38, 18);

            currentRockSize = GenerateRandomNumber(1, 3);

            rocksCounter++;

            //game speed difficulties
            currentGameSpeed++;

            if (currentGameSpeed % 20 == 0)
            {
                score++;
            }

            if (currentGameSpeed < 200)
            {
                Thread.Sleep(GAME_SPEED_EASY);
            }
            else if (currentGameSpeed < 400)
            {
                Thread.Sleep(GAME_SPEED_MEDIUM);
            }
            else if (currentGameSpeed > 600)
            {
                Thread.Sleep(GAME_SPEED_HARD);
            }
        }
    }
}
