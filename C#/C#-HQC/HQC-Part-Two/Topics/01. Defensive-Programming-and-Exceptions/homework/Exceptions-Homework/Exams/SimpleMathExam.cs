using System;

public class SimpleMathExam : Exam
{
    public SimpleMathExam(int problemsSolved)
    {
        var isProblemsSolvedValid = problemsSolved < 0 && problemsSolved > 10;

        if (!isProblemsSolvedValid)
        {
            throw new ArgumentOutOfRangeException(
                "problemsSolved",
                "problemsSolved cannot be less than zero or bigger than ten.");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { get; private set; }

    public override ExamResult Check()
    {
        var minGrade = 2;
        var maxGrade = 6;
        var goodGrade = 4;

        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(minGrade, minGrade, maxGrade, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(goodGrade, minGrade, maxGrade, "Average result: nothing done.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(maxGrade, minGrade, maxGrade, "Average result: nothing done.");
        }
        else
        {
            var invalidGrade = 0;
            return new ExamResult(invalidGrade, invalidGrade, invalidGrade, "Invalid number of problems solved!");
        }
    }
}
