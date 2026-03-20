namespace ProjektC1;

public class Employee : Person
{
    public string Position
    {
        get;
        set;
    }
    public Employee(string firstName, string lastName, string position) : base(firstName, lastName)
    {
        Position = position;
        Type = UserType.Employee;
        MaxActiveRentals = 5;
    }
}