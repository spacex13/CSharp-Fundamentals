using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var phoneNumbersToCall = Console.ReadLine().Split();
        var sitesToVisit = Console.ReadLine().Split();
        Smartphone phone = new Smartphone();

        foreach (var number in phoneNumbersToCall)
        {
            CallNumber(number, phone);
        }

        foreach (var site in sitesToVisit)
        {
            VisitASite(site, phone);
        }
    }

    public static void CallNumber(string number, Smartphone phone)
    {
        try
        {
            if (number.Any(n => !Char.IsDigit(n)))
            {
                throw new ArgumentException("Invalid number!");
            }
            Console.WriteLine(phone.CallPhone(number));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void VisitASite(string site, Smartphone phone)
    {
        try
        {
            if (site.Any(n => Char.IsDigit(n)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            Console.WriteLine(phone.VisitSite(site));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
