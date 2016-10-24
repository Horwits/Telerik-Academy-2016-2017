using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        try
        {
            var substr = StringUtils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine(aoe.Message);
        }

        try
        {
            var subarr = StringUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine(aoe);
        }

        try
        {
            var allarr = StringUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine(aoe);
        }

        try
        {
            var emptyarr = StringUtils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine(aoe);
        }

        try
        {
            Console.WriteLine(StringUtils.ExtractTextEnding("I love C#", 2));
            Console.WriteLine(StringUtils.ExtractTextEnding("Nakov", 4));
            Console.WriteLine(StringUtils.ExtractTextEnding("beer", 4));
            Console.WriteLine(StringUtils.ExtractTextEnding("Hi", 100));
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine(aoe);
        }

        try
        {
            Console.WriteLine($"23 is prime? {PrimeChecker.CheckIfPrime(23)}");
            Console.WriteLine($"33 is prime? {PrimeChecker.CheckIfPrime(33)}");
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine(aoe);
        }

        var peterExams = new List<Exam>();

        try
        {
            peterExams.Add(new SimpleMathExam(2));
            peterExams.Add(new CSharpExam(55));
            peterExams.Add(new CSharpExam(100));
            peterExams.Add(new SimpleMathExam(1));
            peterExams.Add(new CSharpExam(0));
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine(aoe);
        }

        try
        {
            var peter = new Student("Peter", "Petrov", peterExams);
            var peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine($"Average results = {peterAverageResult:p0}");
        }
        catch (ArgumentNullException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }
}
