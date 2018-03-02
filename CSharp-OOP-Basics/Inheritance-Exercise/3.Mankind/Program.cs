using System;

namespace _3.Mankind
{
    class Program
    {
        static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var studentFirstName = studentInfo[0];
                var studentLastName = studentInfo[1];
                var studentFacultyNum = studentInfo[2];

                Student student = new Student(studentFirstName, studentLastName, studentFacultyNum);

                var workerInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var workerFirstName = workerInfo[0];
                var workerLastName = workerInfo[1];
                var weekSalary = decimal.Parse(workerInfo[2]);
                var workingHoursPerDay = double.Parse(workerInfo[3]);

                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workingHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
