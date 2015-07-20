using System;

public class SimpleMathExam : Exam
{
    private const int MinGrade = 2;
    private const int MaxGrade = 6;
    private const int MinProblemsSolved = 0;
    private const int MaxProblemsSolved = 2;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            return this.problemsSolved;
        }
        private set
        {
            if (value < MinProblemsSolved || value > MaxProblemsSolved)
            {
                throw new ArgumentOutOfRangeException(
                    String.Format("Problems solved must be between {0} and {1}",
                    MinProblemsSolved,
                    MaxProblemsSolved));
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult Check()
    {
        switch (this.problemsSolved)
        {
            case 0:
                return new ExamResult(2, MinGrade, MaxGrade, "Bad result: no problems solved.");
            case 1:
                return new ExamResult(4, MinGrade, MaxGrade, "Average result: half of the problems solved.");
            case 2:
                return new ExamResult(6, MinGrade, MaxGrade, "Excellent result: all problems solved.");
            default:
                return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }       
    }
}
