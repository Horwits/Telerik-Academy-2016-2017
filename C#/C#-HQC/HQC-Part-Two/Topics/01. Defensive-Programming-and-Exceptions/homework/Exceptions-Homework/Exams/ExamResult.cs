using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        var isGradeLessThanZero = grade < 0;
        if (isGradeLessThanZero)
        {
            throw new ArgumentOutOfRangeException("grade", "grade cannot be less than zero.");
        }

        var isMinGradeLessThanZero = minGrade < 0;
        if (isMinGradeLessThanZero)
        {
            throw new ArgumentOutOfRangeException("minGrade", "minGrade cannot be less than zero.");
        }

        var isMaxGradeLessOrEqualToMinGrade = maxGrade <= minGrade;
        if (isMaxGradeLessOrEqualToMinGrade)
        {
            throw new ArgumentOutOfRangeException("maxGrade", "maxGrade cannot be equal or less than minGrade.");
        }

        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentException("comments", "comments cannot be null or empty.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
