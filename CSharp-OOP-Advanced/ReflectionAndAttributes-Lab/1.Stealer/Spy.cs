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
}