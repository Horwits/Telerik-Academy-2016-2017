using System;

class Program
{
    static int BinarySearch(int[] array, int value, int left, int right)
    {
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (array[middle] == value)
            {
                return middle;
            }
            else if (array[middle] > value)
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int x = int.Parse(Console.ReadLine());
        var position = BinarySearch(numbers, x, 0, n);

        Console.WriteLine(position);
    }
}
