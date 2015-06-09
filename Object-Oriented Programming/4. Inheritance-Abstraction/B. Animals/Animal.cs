using System;

public abstract class Animal : ISoundProducible
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Name", "Value cannot be empty");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Age", "Value cannot be negative.");
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get
        {
            return this.gender;
        }

        set
        {
            if (value != "male" && value != "female")
            {
                throw new ArgumentException("Value must be either male or female.");
            }

            this.gender = value;
        }
    }

    public abstract string ProduceSound();
}