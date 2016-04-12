using System;

class FirstLargerThanNeighbours
{
    static int PositionOfFirstNumberBiggerThanneighbours(string[] numbersToString, int length)
    {
        int position = 0;
        bool isLargerThanNeighbours = true;
        for (int previous = 0, current = 1, next = 2; previous < length - 2; previous++)
        {
            if (current < length - 1 && next < length)
            {
                int previosNumber = int.Parse(numbersToString[previous]);
                int currentNumber = int.Parse(numbersToString[current]);
                int nextNumber = int.Parse(numbersToString[next]);

                isLargerThanNeighbours = previosNumber < currentNumber && currentNumber > nextNumber;
                if (isLargerThanNeighbours)
                {
                    position = current;
                    break;
                }

                current++;
                next++;
            }
        }

        if (!isLargerThanNeighbours)
        {
            return -1;
        }

        return position;
    }

    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        var numbersToString = Console.ReadLine().Split(' ');

        Console.WriteLine(PositionOfFirstNumberBiggerThanneighbours(numbersToString, length));
    }
}
