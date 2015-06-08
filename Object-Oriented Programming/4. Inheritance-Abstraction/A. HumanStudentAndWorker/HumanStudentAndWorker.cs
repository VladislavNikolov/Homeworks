using System;
using System.Collections.Generic;
using System.Linq;

public class HumanStudentAndWorker
{
    public static void Main()
    {
        // Initialize a list of students
        List<Student> students = new List<Student>
        {
            new Student("Pesho", "Ivanov", "1445"),
            new Student("Ivane", "Peshev", "1385"),
            new Student("Maria", "Todorova", "1276"),
            new Student("Ginka", "Penkina", "9457"),
            new Student("Todor", "Georgiev", "3467"),
            new Student("Georgi", "Todorov", "2795"),
            new Student("Mincho", "Praznikov", "3764"),
            new Student("Pantalei", "Koshev", "8427"),
            new Student("Lukcho", "Mirizliikov", "3491"),
            new Student("Pesho", "Ivanov", "5761")
        };

        // Sort using lambda expression
        var sortStudents = students.OrderBy(facNum => facNum.FacultyNumber);

        foreach (var student in sortStudents)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();

        // Initialize a list of workers
        List<Worker> workers = new List<Worker>
        {
            new Worker("Gosho", "Kolev", 560, 8),
            new Worker("Kolio", "Penev", 1200, 7),
            new Worker("Atanaska", "Moldovska", 450, 5),
            new Worker("Krastan", "Penev", 800, 6),
            new Worker("Penio", "Penev", 3000, 8),
            new Worker("Pushach", "Alkoholev", 582, 8),
            new Worker("Tincho", "Petkov", 934, 7),
            new Worker("Petar", "Pulev", 1000, 6),
            new Worker("Natalia", "Kobilkina", 5841, 8),
            new Worker("Konstantin", "Prustev", 1500, 8),
        };

        // Sort using LINQ query
        var sortWorkers =
            from worker in workers
            orderby worker.MoneyPerHour() descending
            select worker;

        foreach (var worker in sortWorkers)
        {
            Console.WriteLine(worker);
        }

        Console.WriteLine();

        // Initialize a list of humans and add students and workers to it
        List<Human> combined = new List<Human>();
        combined.AddRange(students);
        combined.AddRange(workers);

        foreach (var human in combined.OrderBy(firstname => firstname.FirstName).ThenBy(lastname => lastname.LastName))
        {
            Console.WriteLine(human);
        }
    }
}