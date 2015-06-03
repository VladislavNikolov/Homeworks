using System;

public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private int hdd;
    private string screen;
    private Battery battery;
    private decimal price;

    public Laptop(string model, decimal price)
        : this(model, "no data", "no data", 0, "no data", 0, "no data", new Battery(), price)
    {
    }

    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard,
        int hdd, string screen, Battery battery, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Battery = battery;
        this.Price = price;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be null or empty");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be null or empty");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be null or empty");
            }
            this.processor = value;
        }
    }

    public int RAM
    {
        get { return this.ram; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be null or empty");
            }
            this.graphicsCard = value;
        }
    }

    public int HDD
    {
        get { return this.hdd; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be null or empty");
            }
            this.screen = value;
        }
    }

    public Battery Battery { get; set; }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Model: {0}\nPrice: {1}",
            this.Model, 
            this.Price + " lv.");
    }
}