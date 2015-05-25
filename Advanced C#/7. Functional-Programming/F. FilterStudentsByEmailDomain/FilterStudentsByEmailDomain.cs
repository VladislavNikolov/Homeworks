using System;
using System.Collections.Generic;
using System.Linq;

class FilterStudentsByEmailDomain
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


        var sortedQuery =
            from student in students
            where student.Email.Contains("@abv.bg")
            select student;

        Console.WriteLine("All students with email ending with @abv.bg");
        foreach (var student in sortedQuery)
        {
            Console.WriteLine(student.Email);
        }
    }
}
