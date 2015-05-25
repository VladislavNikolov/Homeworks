using System;
using System.Collections.Generic;

public class ClassStudent
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ivan", "Ivanov", 18, "1545", "021234", "ivan@gmail.com", new List<int> {5, 3, 5, 6}, 1),
            new Student("Pesho", "Peshev", 26, "1535", "3592321638", "peshev@abv.bg", new List<int> {5, 2, 5, 6}, 1),
            new Student("Petko", "Petkov", 19, "1546", "07113", "petkov@abv.bg", new List<int> {5, 2, 5, 6}, 2),
            new Student("Goshko", "Goskov", 19, "1542", "083545", "goshov@gmail.com", new List<int> {5, 2, 5, 5}, 2),
            new Student("Mariika", "Marieva", 25, "1555", "+359 2", "niama@ght.gh", new List<int> {6, 2, 6, 4}, 1),
            new Student("Rositza", "Roseva", 20,"1556", "112345", "pakmail@abv.bg", new List<int> {4, 2, 6, 3}, 2),
            new Student("Ivan", "Petkov", 36, "1545", "524354", "zashto@hotmail.com", new List<int> {6, 2, 6, 6}, 3)
        };
    }
}