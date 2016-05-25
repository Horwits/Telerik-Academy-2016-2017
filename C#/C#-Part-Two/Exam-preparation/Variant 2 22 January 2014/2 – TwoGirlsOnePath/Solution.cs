using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Solution
{
    static void Main()
    {
        Console.WriteLine(9000000000000000001 % 8);

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
                Console.WriteLine("{0} {1}", dollyTotalFlowers, mollyTotalFlowers);
                break;
            }
            else if (dollyNoFlowersOnCurrentPosition && mollyNoFlowersOnCurrentPosition)
            {
                Console.WriteLine("Draw");
                break;
            }

            mollyNextPosition = mollyCurrentPosition + path[(long)mollyCurrentPosition];
            if (mollyNextPosition > length - 1)
            {
                while (mollyNextPosition > length)
                {
                    mollyNextPosition -= length;
                }
            }

            dollyNextPosition = dollyCurrentPosition - path[(long)dollyCurrentPosition];
            if (dollyNextPosition < 0)
            {
                while (dollyNextPosition <= 0)
                {
                    dollyNextPosition += length;
                }
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
