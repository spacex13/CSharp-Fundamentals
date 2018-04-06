namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            string line;
            Type classType = typeof(BlackBoxInteger);
            var classInstance = Activator.CreateInstance(classType, true);

            var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            while ((line = Console.ReadLine()) != "END")
            {
                var command = line.Split('_')[0];
                var value = int.Parse(line.Split('_')[1]);

                methods.FirstOrDefault(m => m.Name == command).Invoke(classInstance, new object[] { value });

                foreach (var field in fields)
                {
                    Console.WriteLine(field.GetValue(classInstance).ToString());
                }
            }
        }
    }
}
