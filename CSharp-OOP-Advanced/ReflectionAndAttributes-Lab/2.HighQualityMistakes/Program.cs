using System;

class Program
{
    static void Main()
    {
        Spy spy = new Spy();
        string result = spy.AnalyzeAcessModifiers("Hacker");
        Console.WriteLine(result);
    }
}