using System;
using System.Linq;

namespace _10.Tuple
{
    class Program
    {
        static void Main()
        {
            var personInfo = Console.ReadLine().Split().ToArray();
            var firstName = personInfo[0];
            var lastName = personInfo[1];
            var address = personInfo[2];

            var fullName = firstName + " " + lastName;
            Tuple<string, string> person = new Tuple<string, string>(fullName, address);
            Console.WriteLine(person);

            var secondLine = Console.ReadLine().Split().ToArray();
            var name = secondLine[0];
            var beer = int.Parse(secondLine[1]);
            Tuple<string, int> person2 = new Tuple<string, int>(name, beer);
            Console.WriteLine(person2);

            var thirdLine = Console.ReadLine().Split().ToArray();
            var num1 = int.Parse(thirdLine[0]);
            var num2 = double.Parse(thirdLine[1]);

            Tuple<int, double> numbers = new Tuple<int, double>(num1, num2);
            Console.WriteLine(numbers);
        }
    }
}
