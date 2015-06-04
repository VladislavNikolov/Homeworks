using System;

public class Computer
{
    private string name;

    public Computer(string name, decimal price) : this(name, new Component("No processor", 0),
        new Component("No graphics card", 0), new Component("No motherboard", 0))
    {        
    }

    public Computer(string name, Component processor, Component graphicsCard, Component motherboard)
    {
        this.Name = name;
        this.Processor = processor;
        this.GraphicsCard = graphicsCard;
        this.Motherboard = motherboard;
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

    public Component Processor { get; set; }

    public Component GraphicsCard { get; set; }

    public Component Motherboard { get; set; }

    public decimal Price
    {
        get
        {
            return this.Processor.Price + this.GraphicsCard.Price + this.Motherboard.Price;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Computer name: {0}", this.Name);
        Console.WriteLine("Processor name: {0}\nProcessor price: {1:F2} lv.", 
            this.Processor.Name, this.Processor.Price);
        Console.WriteLine("Graphics card name: {0}\nGraphics card price: {1:F2} lv.",
            this.GraphicsCard.Name, this.GraphicsCard.Price);
        Console.WriteLine("Motherboard name: {0}\nMotherboard price: {1:F2} lv.", 
            this.Motherboard.Name, this.Motherboard.Price);
        Console.WriteLine("Computer price: {0:F2} lv.", Price);
        Console.WriteLine();
    }
}