public class Employee
{
    private string name;
    private double salary;
    private string position;
    private string email;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public string Position
    {
        get { return position; }
        set { position = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Employee(string name, double salary, string position, int age, string email)
    {
        this.name = name;
        this.salary = salary;
        this.age = age;
        this.position = position;
        this.email = email;
    }

}

