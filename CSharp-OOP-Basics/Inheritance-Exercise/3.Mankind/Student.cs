using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private const int MIN_LENGTH = 5;
    private const int MAX_LENGTH = 10;

    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNum) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNum;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        protected set
        {
            if (value.Length < MIN_LENGTH || value.Length > MAX_LENGTH ||
                !value.All(char.IsLetterOrDigit))
            {
                throw  new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString()).AppendLine($"Faculty number: {FacultyNumber}");

        return sb.ToString();
    }
}

