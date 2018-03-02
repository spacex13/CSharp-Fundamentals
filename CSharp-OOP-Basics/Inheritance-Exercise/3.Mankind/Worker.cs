using System;
using System.Text;

public class Worker : Human
{
    private const int MIN_SALARY = 10;
    private const int MIN_WORK_HOURS = 1;
    private const int MAX_WORK_HOURS = 12;

    private decimal weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        protected set
        {
            if (value <= MIN_SALARY)
            {
                throw  new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        protected set
        {
            if (value < MIN_WORK_HOURS || value > MAX_WORK_HOURS)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    public decimal SalaryPerHour()
    {
        return weekSalary / 5 / (decimal)workHoursPerDay;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendLine($"Week Salary: {WeekSalary:f2}")
            .AppendLine($"Hours per day: {workHoursPerDay:f2}")
            .AppendLine($"Salary per hour: {SalaryPerHour():f2}");

        return sb.ToString();
    }
}

