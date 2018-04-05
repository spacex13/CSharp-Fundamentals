using System;
using System.Linq;

public class CommandInterpreter
{
    public void Start()
    {
        CustomList<string> list = new CustomList<string>();

        string commandArgs;
        while ((commandArgs = Console.ReadLine()) != "END")
        {
            var commandInfo = commandArgs.Split().ToArray();
            var command = commandInfo[0];
            var result = "";

            switch (command)
            {
                case "Add":
                    var element = commandInfo[1];
                    list.Add(element);
                    break;

                case "Remove":
                    var index = int.Parse(commandInfo[1]);
                    list.Remove(index);
                    break;

                case "Contains":
                    element = commandInfo[1];
                    result = list.Contains(element).ToString();
                    break;

                case "Swap":
                    var index1 = int.Parse(commandInfo[1]);
                    var index2 = int.Parse(commandInfo[2]);
                    list.Swap(index1, index2);
                    break;

                case "Greater":
                    element = commandInfo[1];
                    result = list.CountGreaterThan(element).ToString();
                    break;

                case "Max":
                    result = list.Max();
                    break;

                case "Min":
                    result = list.Min();
                    break;

                case "Print":
                    result = list.ToString();
                    break;
            }

            if (result != "")
                Console.WriteLine(result);
        }
    }
}