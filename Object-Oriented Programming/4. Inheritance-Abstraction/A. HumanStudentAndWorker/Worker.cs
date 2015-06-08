using System;

public class Worker : Human
{
    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) 
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }

            this.weekSalary = value;
        }
    }

    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal MoneyPerHour()
    {
        decimal result = (this.weekSalary / 5) / this.WorkHoursPerDay;

        return result;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1:F2} lv.", base.ToString(), this.MoneyPerHour());
    }
}