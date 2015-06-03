using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age)
        : this(name, age, null)
    {
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name should not be empty");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid age");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if (value == null || value.Contains("@"))
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("Invalid email");
            }
        }
    }

    public override string ToString()
    {
        return String.Format("Name: {0}, Age: {1}, Email: {2}", 
            this.Name, this.Age, this.Email);
    }
}
