using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
    {
        Type classType = Type.GetType(classToInvestigate);

        var result = new StringBuilder($"Class under investigation: {classType}" + Environment.NewLine);

        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (FieldInfo field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
        {
            result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return result.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        var result = new StringBuilder();

        FieldInfo[] fields = classType.GetFields();
        Object classInstance = Activator.CreateInstance(classType, new object[] { });
        MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var field in fields)
        {
            if (!field.IsPrivate)
                result.AppendLine($"{field.Name} must be private!");
        }

        foreach (var method in methods.Where(m => m.Name.StartsWith("get")))
        {
            if (!method.IsPublic)
                result.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var method in methods.Where(m => m.Name.StartsWith("set")))
        {
            if (!method.IsPrivate)
                result.AppendLine($"{method.Name} have to be private!");
        }

        return result.ToString().Trim();
    }
}