using System;

class LargerThanneighboursChecker
{
    static int CountNumberBiggerThanneighbours(string[] numbersToString, int length)
    {
        int counter = 0;
        for (int previous = 0, current = 1, next = 2; previous < length - 2; previous++)
        {
            if (current < length - 1 && next < length)
            {
                int previosNumber = int.Parse(numbersToString[previous]);
                int currentNumber = int.Parse(numbersToString[current]);
                int nextNumber = int.Parse(numbersToString[next]);

                bool isLargerThanNeighbours = previosNumber < currentNumber && currentNumber > nextNumber;
                if (isLargerThanNeighbours)
                {
                    counter++;
                }

                current++;
                next++;
            }
        }

        return counter;
    }

    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        var numbersToString = Console.ReadLine().Split(' ');

        Console.WriteLine(CountNumberBiggerThanneighbours(numbersToString, length));
    }
}
