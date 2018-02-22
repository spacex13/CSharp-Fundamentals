public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public string FirstName
    {
        get { return firstName; }
    }

    public string LastName
    {
        get { return lastName; }
    }

    public int Age
    {
        get { return age; }
    }

    public decimal Salary
    {
        get { return salary; }
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age > 30)
        {
            this.salary += this.salary * percentage / 100;
        }
        else
        {
            this.salary += this.salary * percentage / 200;
        }       
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
    }
}
