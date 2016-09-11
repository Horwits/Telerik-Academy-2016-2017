namespace Methods.Utils
{
    using System;

    internal class MathUtils
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            var semiPerimeter = (a + b + c) / 2;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return area;
        }

        internal static double CalcDistance(
            double firstPointX,
            double firstPointY,
            double secondPointX,
            double secondPointY,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = firstPointY == secondPointY;
            isVertical = firstPointX == secondPointX;

            var distanceX = secondPointX - firstPointX;
            var distanceY = secondPointY - firstPointY;

            var distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
            return distance;
        }

        internal static string GetNumberToEnglishWord(int number)
        {
            var numberAsWord = string.Empty;
            switch (number)
            {
                case 0:
                    numberAsWord = "zero";
                    break;
                case 1:
                    numberAsWord = "one";
                    break;
                case 2:
                    numberAsWord = "two";
                    break;
                case 3:
                    numberAsWord = "three";
                    break;
                case 4:
                    numberAsWord = "four";
                    break;
                case 5:
                    numberAsWord = "five";
                    break;
                case 6:
                    numberAsWord = "six";
                    break;
                case 7:
                    numberAsWord = "seven";
                    break;
                case 8:
                    numberAsWord = "eight";
                    break;
                case 9:
                    numberAsWord = "nine";
                    break;
                default: throw new ArgumentException("Invalid number!");
            }

            return numberAsWord;
        }

        internal static int GetMaxNumberInArray(params int[] elements)
        {
            var elementsLength = elements.Length;
            var isElementsValid = elements != null || elementsLength != 0;
            if (!isElementsValid)
            {
                throw new ArgumentException(nameof(elements));
            }

            var maxValue = elements[0];
            for (int i = 1; i < elementsLength; i++)
            {
                var currentValue = elements[i];
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
            }

            return maxValue;
        }
    }
}