using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Department> departments = new List<Department>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            string name = input[0];
            double salary = double.Parse(input[1]);
            string position = input[2];
            string depName = input[3];
            string email = "n/a";
            int age = -1;

            if (input.Length == 5)
            {
                bool isAge = int.TryParse(input[4], out age);

                if (!isAge)
                {
                    email = input[4];
                    age = -1;
                }
            }
            else if (input.Length == 6)
            {
                email = input[4];
                age = int.Parse(input[5]);
            }

            if (!departments.Any(d => d.Name == depName))
            {
                Department dep = new Department(depName);
                departments.Add(dep);
            }

            Employee employee = new Employee(name, salary, position, age, email);

            var department = departments.First(d => d.Name == depName);
            department.AddEmployee(employee);
        }

        var highest = departments.OrderByDescending(d => d.AverageSalary).First();

        Console.WriteLine($"Highest Average Salary: {highest.Name}");
        foreach (var e in highest.Employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{e.Name} {e.Salary:f2} {e.Email} {e.Age}");
        }
    }
}

