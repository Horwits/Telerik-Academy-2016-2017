namespace Extensions.IEnum
{
    using System;
    using System.Collections.Generic;

    public static class IEnumExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            T sum = default(T);

            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            T product = default(T);
            var count = 0;
            foreach (var item in collection)
            {
                if (count < 1)
                {
                    product = item;
                    count++;
                    continue;
                }

                product *= (dynamic)item;

                count++;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            T min = default(T);
            var count = 0;

            foreach (var item in collection)
            {
                if (count < 1)
                {
                    min = item;
                }

                if (min > (dynamic)item)
                {
                    min = item;
                }

                count++;
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            T max = default(T);
            var count = 0;

            foreach (var item in collection)
            {
                if (count < 1)
                {
                    max = item;
                }

                if (max < (dynamic)item)
                {
                    max = item;
                }

                count++;
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
            where T : IComparable<T>
        {
            var count = 0;

            T sum = default(T);

            foreach (var item in collection)
            {
                sum += (dynamic)item;
                count++;
            }

            T average = sum / (dynamic)count;
            return average;
        }
    }
}
