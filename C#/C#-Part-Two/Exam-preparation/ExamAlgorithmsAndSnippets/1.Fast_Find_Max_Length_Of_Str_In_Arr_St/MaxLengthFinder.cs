using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MaxLengthFinder
{
    static string[] words = new string[] { "Fun", "exam", "here" };
    static int maxLength = int.MinValue;

    //static void FindMaxLengthOfWordsInString()
    //{
    //
    //    var res = words.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
    //    maxLength = res.Length;
    //    //maxLength = int.MinValue;
    //    //foreach (var word in words)
    //    //{
    //    //    int currentLength = word.Length;
    //    //    maxLength = Math.Max(currentLength, maxLength);
    //    //}
    //}

    static void FindMaxLengthOfWordsInString()
    {
        foreach (var word in words)
        {
            int currentLength = word.Length;
            maxLength = Math.Max(currentLength, maxLength);
        }
    }

    public static void Main(string[] args)
    {
        var fastest = new Stopwatch();
        fastest.Start();
        FindMaxLengthOfWordsInString();
        fastest.Stop();
        Console.WriteLine(fastest.Elapsed);
    }
}
