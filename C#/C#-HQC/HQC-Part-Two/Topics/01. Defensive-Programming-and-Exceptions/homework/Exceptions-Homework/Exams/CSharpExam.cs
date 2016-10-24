using System;

public class CSharpExam : Exam
{
    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException("Score", "Score cannot be less than zero.");
        }

        this.Score = score;
    }

    public int Score { get; private set; }

    public override ExamResult Check()
    {
        var isScoreLessThanZero = this.Score < 0;
        var isScoreBiggerThanOneHundred = this.Score > 100;
        if (isScoreLessThanZero || isScoreBiggerThanOneHundred)
        {
            throw new ArgumentOutOfRangeException("Score", "Score cannot be less than zero or bigger than one hundred.");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
