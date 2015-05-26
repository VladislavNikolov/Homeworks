using System;
using System.Collections.Generic;
using System.Linq;

class StudentsEnrolledIn2014
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ivan", "Vladev", 18, "154514", "02123484", "ivan@gmail.com", new List<int> {5, 3, 5, 6}, 1),
            new Student("Pesho", "Petkov", 26, "153514", "+3592321638", "peshev@abv.bg", new List<int> {5, 2, 5, 2}, 1),
            new Student("Petko", "Goskov", 19, "154615", "071132992", "petkov@abv.bg", new List<int> {5, 2, 5, 6}, 2),
            new Student("Goshko", "Peshev", 19, "154214", "083542255", "goshov@gmail.com", new List<int> {5, 2, 2, 5}, 2),
            new Student("Mariika", "Roseva", 25, "155515", "+359 2354515", "niama@ght.gh", new List<int> {6, 2, 6, 4}, 1),
            new Student("Rositza", "Marieva", 20,"155615", "112344265", "pakmail@abv.bg", new List<int> {4, 2, 6, 3}, 2),
            new Student("Vlado", "Petkov", 36, "154514", "5229264354", "zashto@hotmail.com", new List<int> {6, 2, 6, 6}, 1)
        };

        var studentQuery =
            from student in students 
            where student.FacultyNumber.EndsWith("14")
            select new
            {
                FullName = student.FirstName + " " + student.LastName,
                Marks = string.Join(" ", student.Marks)
            };

        Console.WriteLine("Marks of the students that enrolled in 2014:");
        foreach (var student in studentQuery)
        {
            Console.WriteLine("{0}: {1}", student.FullName, student.Marks);
        }
    }
}
