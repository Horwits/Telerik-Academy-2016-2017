using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        var isFirstNameNull = firstName == null;
        if (isFirstNameNull)
        {
            throw new ArgumentNullException("firstName", "Invalid first name!");
        }

        var isFirstNameValid = !string.IsNullOrEmpty(firstName);
        if (isFirstNameValid)
        {
            throw new FormatException("Invalid first name.");
        }

        var isLastNameNull = lastName == null;
        if (isLastNameNull)
        {
            throw new ArgumentNullException("lastName", "Invalid last name!");
        }

        var isLastNameValid = !string.IsNullOrEmpty(lastName);
        if (isLastNameValid)
        {
            throw new FormatException("Invalid last name.");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public IList<Exam> Exams
    {
        get
        {
            return new List<Exam>(this.exams);
        }

        private set
        {
            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        var areExamsNull = this.Exams == null;
        if (areExamsNull)
        {
            throw new ArgumentNullException("Exams", "The student has no exams!");
        }

        return this.Exams
            .Select(exam => exam.Check())
            .ToList();
    }

    public double CalcAverageExamResultInPercents()
    {
        var areExamsNull = this.Exams == null;
        if (areExamsNull)
        {
            throw new ArgumentNullException("Exams", "Exams cannot be null.");
        }

        var areExamsEmpty = this.Exams.Count == 0;
        if (areExamsEmpty)
        {
            throw new ArgumentException("Exams", "The student has no exams!");
        }

        var examScore = new double[this.Exams.Count];
        var examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
