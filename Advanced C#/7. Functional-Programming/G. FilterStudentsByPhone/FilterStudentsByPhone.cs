using System;
using System.Collections.Generic;
using System.Linq;

class FilterStudentsByPhone
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ivan", "Vladev", 18, "1545", "02123484", "ivan@gmail.com", new List<int> {5, 3, 5, 6}, 1),
            new Student("Pesho", "Petkov", 26, "1535", "+3592321638", "peshev@abv.bg", new List<int> {5, 2, 5, 6}, 1),
            new Student("Petko", "Goskov", 19, "1546", "071132992", "petkov@abv.bg", new List<int> {5, 2, 5, 6}, 2),
            new Student("Goshko", "Peshev", 19, "1542", "083542255", "goshov@gmail.com", new List<int> {5, 2, 5, 5}, 2),
            new Student("Mariika", "Roseva", 25, "1555", "+359 2354515", "niama@ght.gh", new List<int> {6, 2, 6, 4}, 1),
            new Student("Rositza", "Marieva", 20,"1556", "112344265", "pakmail@abv.bg", new List<int> {4, 2, 6, 3}, 2),
            new Student("Vlado", "Petkov", 36, "1545", "5229264354", "zashto@hotmail.com", new List<int> {6, 2, 6, 6}, 1)
        };

        var studentQuery =
            from student in students
            where
                student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") ||
                student.Phone.StartsWith("+359 2")
            select student;

        Console.WriteLine("Students with phones in Sofia:");
        foreach (var student in studentQuery)
        {
            Console.WriteLine(student.Phone);
        }
    }
}