public class Smartphone : IPhoneCall, IWebBrowsing
{
    public string CallPhone(string number)
    {
        return $"Calling... {number}";
    }

    public string VisitSite(string site)
    {
        return $"Browsing: {site}!";
    }
}

