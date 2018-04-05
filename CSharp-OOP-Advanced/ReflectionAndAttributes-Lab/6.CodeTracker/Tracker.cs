using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

        foreach (var method in methods)
        {
            if(method.CustomAttributes.Any(n => n.AttributeType == typeof(SoftUniAttribute)))
            {
                var attributes = method.GetCustomAttributes(false);

                foreach (SoftUniAttribute attr in attributes)
                {
                    System.Console.WriteLine($"{method.Name} is written by {attr.Name}");
                }
            }
        }
    }
}