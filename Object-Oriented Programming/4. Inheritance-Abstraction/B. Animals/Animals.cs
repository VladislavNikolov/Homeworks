using System;
using System.Linq;

public class Animals
{
    public static void Main()
    {
        Animal[] animals = new Animal[]
        {
            new Dog("Sharo", 3, "male"),
            new Frog("Kikirica", 1, "female"),
            new Cat("Sharo", 4, "male"),
            new Frog("Gosho", 4, "male"),
            new Tomcat("Whiskers", 5),
            new Kitten("Lady", 2),
            new Dog("Rex", 5, "male"),
            new Dog("Killer", 3, "male"),
            new Frog("Greeny", 5, "female"),
            new Cat("Tails", 1, "male")
        };

        var averageAge =
                from animal in animals
                group animal by (animal is Cat) ? typeof(Cat) : animal.GetType() into g
                select new { GroupName = g.Key.Name, AverageAge = g.Average(a => a.Age) };

        foreach (var animal in averageAge)
        {
            Console.WriteLine("{0} - average age: {1:F2}", animal.GroupName, animal.AverageAge);
        }

        Console.WriteLine();

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.ProduceSound());
        }
    }
}