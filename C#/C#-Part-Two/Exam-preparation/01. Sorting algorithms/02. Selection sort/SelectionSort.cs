using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Selection_sort
{
    class SelectionSort
    {
        static int FastSwapNumberElemnts(int a, int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;

            return a;
        }

        static char FindMinChar(StringBuilder text)
        {
            var min = text[0];

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] < min)
                {
                    min = text[i];
                }
            }

            return min;
        }

        static StringBuilder Swap(StringBuilder text, int curPos, int minPos)
        {
            char temp = text[curPos];
            text[curPos] = text[minPos];
            text[minPos] = temp;

            return text;
        }

        static string SelectionSortAlgorithm(string text)
        {
            text = text.ToLower();
            var result = new StringBuilder(text);
            int i, j;

            /* advance the position through the entire array */
            /*   (could do j < n-1 because single element is also min element) */
            for (j = 0; j < text.Length - 1; j++)
            {
                /* find the min element in the unsorted a[j .. n-1] */

                /* assume the min is the first element */
                int iMin = j;
                /* test against elements after j to find the smallest */
                for (i = j + 1; i < text.Length; i++)
                {
                    /* if this element is less, then it is the new minimum */
                    if (result[i] < result[iMin])
                    {
                        /* found new minimum; remember its index */
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    Swap(result, j, iMin);
                }
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            string text = "dsadsadsa";

            Console.WriteLine(SelectionSortAlgorithm(text));
        }
    }
}
