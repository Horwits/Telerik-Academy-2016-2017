using System;
using System.Linq;

//  80/100 -> 1st test and 2nd test 
//when molly is finished in this case dolly doesn't have to get flowers but if i change it it will ruin other tests

//rewrite it
class Solution
{
    static void Main()
    {
        var path = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => long.Parse(x))
                            .ToArray();

        int mollyMark = -1;
        int dollyMark = -2;

        int length = path.Length;

        decimal mollyTotalFlowers = 0;
        decimal mollyCurrentPosition = 0;
        decimal mollyNextPosition = 0;

        decimal dollyTotalFlowers = 0;
        decimal dollyCurrentPosition = length - 1;
        decimal dollyNextPosition = 0;

        bool mollyNoFlowersOnCurrentPosition = false;
        bool dollyNoFlowersOnCurrentPosition = false;

        while (true)
        {
            if (path[(long)mollyCurrentPosition] == -1 || path[(long)mollyCurrentPosition] == -2)
            {
                mollyNoFlowersOnCurrentPosition = true;
            }

            if (path[(long)dollyCurrentPosition] == -1 || path[(long)dollyCurrentPosition] == -2)
            {
                dollyNoFlowersOnCurrentPosition = true;
            }

            bool areAtSamePos = false;
            var samePosFlowersToLeave = 0;
            if (mollyCurrentPosition == dollyCurrentPosition)
            {
                areAtSamePos = true;

                if (path[(long)mollyCurrentPosition] % 2 == 0)
                {
                    samePosFlowersToLeave = 0;
                }
                else
                {
                    samePosFlowersToLeave = 1;
                }

                if (!mollyNoFlowersOnCurrentPosition)
                {
                    mollyTotalFlowers += path[(long)mollyCurrentPosition] / 2;
                }

                if (!dollyNoFlowersOnCurrentPosition)
                {
                    dollyTotalFlowers += path[(long)dollyCurrentPosition] / 2;
                }
            }
            else
            {
                if (!mollyNoFlowersOnCurrentPosition)
                {
                    mollyTotalFlowers += path[(long)mollyCurrentPosition];
                }

                if (!dollyNoFlowersOnCurrentPosition)
                {
                    dollyTotalFlowers += path[(long)dollyCurrentPosition];
                }
            }

            if (mollyNoFlowersOnCurrentPosition && !dollyNoFlowersOnCurrentPosition)
            {
                Console.WriteLine("Dolly");
                Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
                break;
            }
            else if (dollyNoFlowersOnCurrentPosition && !mollyNoFlowersOnCurrentPosition)
            {
                Console.WriteLine("Molly");
                Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
                break;
            }
            else if (dollyNoFlowersOnCurrentPosition && mollyNoFlowersOnCurrentPosition)
            {
                Console.WriteLine("Draw");
                Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
                break;
            }

            mollyNextPosition = mollyCurrentPosition + path[(long)mollyCurrentPosition];
            if (mollyNextPosition > length - 1)
            {
                mollyNextPosition %= length;
            }

            dollyNextPosition = dollyCurrentPosition - path[(long)dollyCurrentPosition];
            if (dollyNextPosition < 0)
            {
                dollyNextPosition %= length;
                dollyNextPosition += length;
            }

            if (!areAtSamePos)
            {
                path[(long)mollyCurrentPosition] = mollyMark;
                path[(long)dollyCurrentPosition] = dollyMark;
            }
            else
            {
                path[(long)mollyCurrentPosition] = samePosFlowersToLeave;
            }

            mollyCurrentPosition = mollyNextPosition;
            dollyCurrentPosition = dollyNextPosition;
        }
    }
}
