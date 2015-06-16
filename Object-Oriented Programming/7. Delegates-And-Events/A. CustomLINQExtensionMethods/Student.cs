namespace A.CustomLINQExtensionMethods
{
    using System;

    public class Student : IComparable<Student>
    {
        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public string Name { get; set; }

        public int Grade { get; set; }

        public int CompareTo(Student other)
        {
            return 1;
        }
    }
}
