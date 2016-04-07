using System;

class BullsAndCows
{
    static void Main()
    {
        int secretNum = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        for (int i = 1000; i < 9999; i++)
        {
            int currentA = i % 10;

            int currentBulls = 0,
                currentCows = 0;

            if (currentBulls == bulls || currentCows == cows)
            {
                Console.Write("{0} ", i);
            }
        }

    }
}
