﻿using System;

public class Component
{
    private string name;
    private decimal price;

    public Component(string name, decimal price) : this(name, null, price)
    {      
    }

    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public string Details { get; set; }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative");
            }
            this.price = value;
        }
    }
 
}