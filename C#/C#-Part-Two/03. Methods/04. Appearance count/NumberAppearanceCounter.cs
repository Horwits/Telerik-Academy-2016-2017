using System;

class NumberAppearanceCounter
{
    static int CountNumberAppearance(int sizeOfArray, string[] givenArray, int searchedNumber)
    {
        int counter = 0;
        for (int i = 0; i < sizeOfArray; i++)
        {
            var currentNumber = int.Parse(givenArray[i]);
            if (currentNumber == searchedNumber)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());
        var givenArray = Console.ReadLine().Split(' ');
        int searchedNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(CountNumberAppearance(sizeOfArray, givenArray, searchedNumber));
    }
}
