using System;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber) 
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be empty");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0}, Fac. Number: {1}", base.ToString(), this.FacultyNumber);
    }
}