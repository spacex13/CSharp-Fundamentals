using System;

public class DateModifier
{
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
   
    public double DaywBetweenDates()
    {
        return Math.Abs((this.startDate - this.endDate).TotalDays);
    }
}

