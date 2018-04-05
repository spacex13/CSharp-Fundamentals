using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var collection = Console.ReadLine().Split().ToList();
        collection.RemoveAt(0);

        ListyIterator<string> iterator = new ListyIterator<string>(collection.ToArray());

        string command;

        while ((command = Console.ReadLine()) != "END")
        {
            var result = "";
            try
            {
                switch (command)
                {
                    case "Move":
                        result = iterator.Move().ToString();
                        break;
                    case "Print":
                        iterator.Print();
                        break;
                    case "HasNext":
                        result = iterator.HasNext().ToString();
                        break;
                    case "PrintAll":
                        iterator.PrintAll();
                        break;
                }

                if (result != "")
                    Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}