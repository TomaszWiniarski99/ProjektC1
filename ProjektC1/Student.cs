namespace ProjektC1;

public class Student : Person
{
    public string Major
    {
        get;
        set;
    }

    public int Group
    {
        get;
        set;
    }

    public int Year
    {
        get;
        set;
    }
    public Student(int id, string firstName, string lastName, string major, int group, int year) : base(id, firstName, lastName)
    {
        Major = major;
        Group = group;
        Year = year;
    }
}