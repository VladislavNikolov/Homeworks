using System;
using System.Collections.Generic;
using System.Linq;

class StudentsByAge
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ivan", "Vladev", 18, "1545", "021234", "ivan@gmail.com", new List<int> {5, 3, 5, 6}, 1),
            new Student("Pesho", "Petkov", 26, "1535", "3592321638", "peshev@abv.bg", new List<int> {5, 2, 5, 6}, 1),
            new Student("Petko", "Goskov", 19, "1546", "07113", "petkov@abv.bg", new List<int> {5, 2, 5, 6}, 2),
            new Student("Goshko", "Peshev", 19, "1542", "083545", "goshov@gmail.com", new List<int> {5, 2, 5, 5}, 2),
            new Student("Mariika", "Roseva", 25, "1555", "+359 2", "niama@ght.gh", new List<int> {6, 2, 6, 4}, 1),
            new Student("Rositza", "Marieva", 20,"1556", "112345", "pakmail@abv.bg", new List<int> {4, 2, 6, 3}, 2),
            new Student("Vlado", "Petkov", 36, "1545", "524354", "zashto@hotmail.com", new List<int> {6, 2, 6, 6}, 1)
        };

        var studentsQuery =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select new {student.FirstName, student.LastName, student.Age};

        Console.WriteLine("Students with age between 18 and 24:");
        foreach (var student in studentsQuery)
        {
            Console.WriteLine("{0} {1}, Age: {2}", student.FirstName, student.LastName, student.Age);
        }
    }
}