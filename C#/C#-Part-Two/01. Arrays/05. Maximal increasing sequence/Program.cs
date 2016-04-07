using System;

class Program
{
    //static int[] GenerateRandomNumberedArray(int length)
    //{
    //    var array = new int[length];


    //    Random random = new Random();
    //    for (int i = 0; i < length; i++)
    //    {
    //        int currentNum = 0;
    //        currentNum = random.Next(1, 4);

    //        array[i] = currentNum;
    //    }
    //    return array;
    //}

    static int CountMaxIncreasingSequenceInArray(int[] array, int n)
    {
        int maxCounter = 0;
        int currentMax = 0;

        for (int i = 1, j = 0; i < n && j < n; i = j + 1)
        {
            int currentNum = array[j];
            if (array[i] - currentNum == 1)
            {
                currentMax++;
                if (currentMax > maxCounter)
                {
                    maxCounter = currentMax;
                }
            }
            else
            {
                currentMax = 0;
            }

            j++;
        }

        int maxSequenceLength = 0; 
        if (maxCounter > 0)
        {
            maxSequenceLength = maxCounter + 1;
        }

        return maxSequenceLength;
    }

    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = short.Parse(Console.ReadLine());
        }

        //var n = 10;
        //var name = GenerateRandomNumberedArray(n);

        //Console.WriteLine(string.Join(" ,", name));

        Console.WriteLine(CountMaxIncreasingSequenceInArray(numbers, n));
    }
}
