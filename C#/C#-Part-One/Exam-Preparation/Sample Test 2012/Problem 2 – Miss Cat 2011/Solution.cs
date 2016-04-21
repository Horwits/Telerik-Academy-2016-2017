using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstCatVotes = 0,
            secondCatVotes = 0,
            thirdCatVotes = 0,
            fourthCatVotes = 0,
            fifthCatVotes = 0,
            sixthCatVotes = 0,
            seventhCatVotes = 0,
            eightCatVotes = 0,
            ninthCatVotes = 0,
            tenthCatVotes = 0;

        for (int i = 0; i < n; i++)
        {
            int currentVote = int.Parse(Console.ReadLine());
            switch (currentVote)
            {
                case 1: firstCatVotes++; break;
                case 2: secondCatVotes++; break;
                case 3: thirdCatVotes++; break;
                case 4: fourthCatVotes++; break;
                case 5: fifthCatVotes++; break;
                case 6: sixthCatVotes++; break;
                case 7: seventhCatVotes++; break;
                case 8: eightCatVotes++; break;
                case 9: ninthCatVotes++; break;
                case 10: tenthCatVotes++; break;
            }
        }

        Dictionary<string, int> votes = new Dictionary<string, int>();
        votes.Add("1", firstCatVotes);
        votes.Add("2", secondCatVotes);
        votes.Add("3", thirdCatVotes);
        votes.Add("4", fourthCatVotes);
        votes.Add("5", fifthCatVotes);
        votes.Add("6", sixthCatVotes);
        votes.Add("7", seventhCatVotes);
        votes.Add("8", eightCatVotes);
        votes.Add("9", ninthCatVotes);
        votes.Add("10", tenthCatVotes);

        var max = votes.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        Console.WriteLine(max);
    }
}
