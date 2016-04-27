using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        checked
        {
            short c = short.Parse(Console.ReadLine());

            var cars = new List<short>();
            for (int i = 0; i < c; i++)
            {
                cars.Add(short.Parse(Console.ReadLine()));
            }

            int maxSum = 0, maxSeqLengthCounter = 1;

            for (int i = 0; i < c - 1; i++)
            {
                var currentCar = cars[i];
                int seqLengthCounter = 1;
                int currentSum = currentCar;
                if (maxSum == 0 && i == c - 2)
                {
                    foreach (var item in cars)
                    {
                        maxSum = Math.Max(maxSum, item);
                    }
                }

                for (int j = i + 1; j < c; j++)
                {
                    var nextCar = cars[j];
                    if (nextCar > currentCar)
                    {
                        seqLengthCounter++;
                        currentSum += nextCar;

                        if (seqLengthCounter >= maxSeqLengthCounter)
                        {
                            maxSeqLengthCounter = seqLengthCounter;

                            if (currentSum > maxSum)
                            {
                                maxSum = currentSum;
                            }
                        }
                    }
                    else
                    {
                        seqLengthCounter = 0;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}

/**/
