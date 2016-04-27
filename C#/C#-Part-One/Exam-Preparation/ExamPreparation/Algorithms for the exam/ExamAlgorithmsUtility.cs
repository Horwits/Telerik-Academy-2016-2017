using System;
using System.Collections.Generic;

class ExamAlgorithmsUtility
{
    static int FindMaxSumInArray(IEnumerable<int> source)
    {
        int result = int.MinValue;
        int sum = 0;
        int tempStart = 0;

        List<int> tempList = new List<int>(source);

        int startIndex = 0;
        int endIndex = 0;

        for (int index = 0; index < tempList.Count; index++)
        {
            sum += tempList[index];
            if (sum > result)
            {
                result = sum;
                startIndex = tempStart;
                endIndex = index;
            }
            if (sum < 0)
            {
                sum = 0;
                tempStart = index + 1;
            }
        }

        return result;
    }

    static void ReadNNumbersFromConsole(int n)
    {
        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
        }
    }

    static int[] ReadNNumbersFromConsoleToArray(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    static int CalculateFactorial(int searchedNum)
    {
        int factorial = 1;
        for (int i = 1; i <= searchedNum; i++)
        {
            factorial *= i;
        }

        return factorial;
    }

    static byte SetBitToOne(byte value, byte position)
    {
        return value = (byte)(value | (1 << position));
    }

    static byte SetBitToZero(byte value, byte position)
    {
        return value = (byte)(value & ~(1 << position));
    }

    static void Main()
    {
        // Reading 32 bit integer
        int number = int.Parse(Console.ReadLine());

        // swapping 
        // int temp = a;
        // a = b;
        // b = temp;

        //max sum in int array
        int[] intArr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };//6
        int sum = FindMaxSumInArray(intArr);//6

        //reading n numbers
        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    int currentNum = int.Parse(Console.ReadLine());
        //}

        //reading n numbers and adding them to array
        //int n = int.Parse(Console.ReadLine());
        //
        //int[] arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        //factorial
        byte num = 4;
        int factorial = CalculateFactorial(num);

        //return bit on position
        int bitOnPos = (num & (1 << 2)) >> 2;

        int newNum = SetBitToZero(num, 2);

        //Console.WriteLine(newNum);
        //Console.WriteLine((newNum & (1 << 2)) >> 2);

        //only odd numbers

        for (int i = 0; i < num; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();

        /*Things to pay atantion
            overflow, constrains
            if is task 5 - if you need to find bit - 1 - surrounded by 1s - look at game of page in github or local
            most of the times if you have more than 50 points - the error is an overflow or wrongly used var types
        */
    }
}
