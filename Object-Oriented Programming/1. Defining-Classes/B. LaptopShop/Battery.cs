using System;

public class Battery
{
    private string batteryName;
    private double batteryLife;

    public Battery(string batteryName = "no data", double batteryLife = 0)
    {
        this.BatteryName = batteryName;
        this.BatteryLife = batteryLife;
    }

    public string BatteryName
    {
        get { return this.batteryName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Value cannot be null or empty");
            }
            this.batteryName = value;
        }
    }

    public double BatteryLife
    {
        get { return this.batteryLife; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }
            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        return String.Format("Battery name: {0}\nBattery life: {1}",
            this.BatteryName,
            this.BatteryLife != 0 ? this.BatteryLife.ToString() + " hours" : "no data");
    }
}