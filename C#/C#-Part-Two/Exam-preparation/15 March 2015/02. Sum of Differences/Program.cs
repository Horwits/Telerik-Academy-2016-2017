using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //proverka dali na sledva6tata poziciq ne e izvun granicite na masiva
        //dokato currentPos  = 1  + positionJump  = 0 e < ot length - 1
        //positionJump = Math.Max(array[currentPos], )
        using (var reader = new StreamReader(@"../../input.txt"))
        {
            var input = reader.ReadLine().Split(' ');
            //var input = "-5 5 1 8 -4 1 2".Split(' ');

            int currentPos = 1,
                jump = 0,
                lenght = input.Length;

            var oddDifferencesCollector = new List<long>();

            while (currentPos < lenght)
            {
                long currentPosValue = long.Parse(input[currentPos]);
                long previousPosValue = long.Parse(input[currentPos - 1]);

                long difference = (Math.Max(currentPosValue, previousPosValue) - Math.Min(currentPosValue, previousPosValue));

                var isDifferenceOdd = difference % 2 == 1;
                if (isDifferenceOdd)
                {
                    oddDifferencesCollector.Add(difference);
                }

                jump = isDifferenceOdd ? 1 : 2;

                currentPos = currentPos + jump;
            }

            Console.WriteLine(oddDifferencesCollector.Sum());
        }
    }
}
