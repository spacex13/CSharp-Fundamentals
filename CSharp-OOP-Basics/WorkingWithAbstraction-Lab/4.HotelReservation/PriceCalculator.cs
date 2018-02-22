using System;

public class PriceCalculator
{
    public decimal PricePerDay { get; set; }
    public int Days { get; set; }

    public enum Season
    {
        Autumn = 1,
        Spring,
        Winter,
        Summer
    }

    public enum Discount
    {
        None,
        SecondVisit = 10,
        VIP = 20
    }

    public Season season { get; set; }
    public Discount discount { get; set; }

    public PriceCalculator(decimal perDay, int days, string season, string discount)
    {
        PricePerDay = perDay;
        Days = days;
        this.discount = Enum.Parse<Discount>(discount);
        this.season = Enum.Parse<Season>(season);
    }

    public decimal TotalPrice()
    {
        decimal nights = PricePerDay * Days * (int)season;
        decimal result = nights - nights * ((decimal)discount / 100);
        return result;
    }
}
