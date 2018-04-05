using System;
using System.Linq;

namespace _11.Threeuple
{
    class Program
    {
        static void Main()
        {
            var person = FirstThreeuple();
            Console.WriteLine(person);

            var drinks = SecondThreeuple();
            Console.WriteLine(drinks);

            var bankInfo = ThirdThreeuple();
            Console.WriteLine(bankInfo);
        }

        private static Threeuple<string, string, string> FirstThreeuple()
        {
            var personInfo = Console.ReadLine().Split().ToArray();
            var firstName = personInfo[0];
            var lastName = personInfo[1];
            var address = personInfo[2];
            var town = personInfo[3];

            var fullName = firstName + " " + lastName;
            Threeuple<string, string, string> person = new Threeuple<string, string, string>(fullName, address, town);

            return person;
        }

        private static Threeuple<string, int, bool> SecondThreeuple()
        {
            var line = Console.ReadLine().Split().ToArray();
            var name = line[0];
            var beer = int.Parse(line[1]);
            var drinkOrNotInfo = line[2];

            bool drinkOrNot = false;

            if (drinkOrNotInfo == "drunk")
                drinkOrNot = true;

            Threeuple<string, int, bool> drinks = new Threeuple<string, int, bool>(name, beer, drinkOrNot);

            return drinks;
        }

        private static Threeuple<string, double, string> ThirdThreeuple()
        {
            var line = Console.ReadLine().Split().ToArray();
            var name = line[0];
            var accountBalance = double.Parse(line[1]);
            var bankName = line[2];

            Threeuple<string, double, string> bankInfo = new Threeuple<string, double, string>(name, accountBalance, bankName);

            return bankInfo;
        }
    }
}
