using System;

class BonusScoreAplier
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()),
            score = 0;

        switch (number)
        {
            case 1:
            case 2:
            case 3:
                score = number * 10;
                Console.WriteLine(score);
                break;
            case 4:
            case 5:
            case 6:
                score = number * 100;
                Console.WriteLine(score);
                break;
            case 7:
            case 8:
            case 9:
                score = number * 1000;
                Console.WriteLine(score);
                break;
            default:
                Console.WriteLine("invalid score");
                break;
        }
    }
}
