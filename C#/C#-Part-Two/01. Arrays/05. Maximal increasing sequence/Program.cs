using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] mass = new double[n];
        for (int i = 0; i < n; i++)
        {
            mass[i] = double.Parse(Console.ReadLine());
        }
        int maximalSequence = 1;
        int maximalSequenceTemp = 1;
        for (int i = 1; i < n; i++)
        {
            if (mass[i] > mass[i - 1])
            {
                maximalSequenceTemp++;
                maximalSequence = (maximalSequence > maximalSequenceTemp) ? maximalSequence : maximalSequenceTemp;

            }
            else
            {
                maximalSequence = (maximalSequence > maximalSequenceTemp) ? maximalSequence : maximalSequenceTemp;
                maximalSequenceTemp = 1;
            }
        }
        Console.WriteLine(maximalSequence);
    }
}
