using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        string commandArgs;

        while((commandArgs = Console.ReadLine()) != "END")
        {
            try
            {
                var commandInfo = commandArgs.Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = commandInfo[0];

                switch (command)
                {
                    case "Pop":
                        stack.Pop();
                        break;
                    case "Push":
                        stack.Push(commandInfo.Skip(1).ToArray());
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}