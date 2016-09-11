//-----------------------------------------------------------------------
// <copyright file="Statistics.cs" company="Telerik">
//      Copyright (c) Telerik.
// </copyright>
//-----------------------------------------------------------------------
namespace Homework
{
    using System;

    public class Statistics
    {
        public void PrintStatistics(double[] collection, int elementsCount)
        {
            var maxValue = this.CalculateMaxValue(collection, elementsCount);
            this.PrintToConsole(maxValue);

            var minValue = this.CalculateMinValue(collection, elementsCount);
            this.PrintToConsole(minValue);

            var elementsSum = this.CalculateElementsSum(collection);
            var averageResult = elementsSum / elementsCount;
            this.PrintToConsole(averageResult);
        }

        private double CalculateMinValue(double[] collection, int elementsCount)
        {
            var minValue = collection[0];
            for (int i = 0; i < elementsCount; i++)
            {
                if (collection[i] < minValue)
                {
                    minValue = collection[i];
                }
            }

            return minValue;
        }

        private double CalculateMaxValue(double[] collection, int elementsCount)
        {
            var maxValue = collection[0];
            for (int i = 0; i < elementsCount; i++)
            {
                if (collection[i] > maxValue)
                {
                    maxValue = collection[i];
                }
            }

            return maxValue;
        }

        private double CalculateElementsSum(double[] collection)
        {
            var elementsSum = default(double);
            var collectionLength = collection.Length;
            for (int i = 0; i < collectionLength; i++)
            {
                elementsSum += collection[i];
            }

            return elementsSum;
        }

        private void PrintToConsole(double value)
        {
            Console.WriteLine(value);
        }
    }
}
