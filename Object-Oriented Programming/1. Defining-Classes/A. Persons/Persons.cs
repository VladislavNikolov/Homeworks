using System;

class Persons
{
    static void Main()
    {
        Person man = new Person("Pesho", 21, "pesho@abv.bg");
        Person woman = new Person("Maria", 18);

        //Initialization with invalid arguments
        //Person noName = new Person("", 18);
        //Person emptyName = new Person("   ", 18);
        //Person tooYoung = new Person("Pesho", 0);
        //Person tooOld = new Person("Pesho", 101);
        //Person wrongEmail = new Person("Pesho", 21, "peshka");

        Console.WriteLine(man);
        Console.WriteLine(woman);
    }
}