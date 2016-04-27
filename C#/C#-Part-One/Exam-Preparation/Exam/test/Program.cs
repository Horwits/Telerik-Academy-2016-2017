using System;
using System.Collections.Generic;

namespace MaximumSumSubarray
{
    public class Program
    {
        static int MaxSumSubarray(int[] a)
        {

            int start = 0;
            int len = 1;
            int sum = a[0];

            int curStart = 0;
            int curLen = 1;
            int curSum = a[0];

            for (int i = 1; i < a.Length; i++)
            {

                if (a[i] >= curSum + a[i])
                {
                    curStart = i;
                    curLen = 1;
                    curSum = a[i];
                }
                else
                {
                    curLen++;
                    curSum += a[i];
                }

                if ((curSum > sum) ||
                    (curSum == sum && curLen < len) ||
                    (curSum == sum && curLen == len && curStart < start))
                {
                    start = curStart;
                    len = curLen;
                    sum = curSum;
                }

            }

            return sum;

        }

        static void Main(string[] args)
        {
            short c = short.Parse(Console.ReadLine());

            var cars = new int[c];
            for (int i = 0; i < c; i++)
            {
                cars[i] = int.Parse(Console.ReadLine());
            }

            var sums = new List<int>();
            
                int sum = MaxSumSubarray(cars);
                sums.Add(sum);

            int maxSum = 0;
            foreach (var s in sums)
            {
                maxSum = Math.Max(maxSum, s);
            }

            Console.WriteLine(maxSum);
        }
    }
}