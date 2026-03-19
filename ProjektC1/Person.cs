namespace ProjektC1;

public abstract class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Rating { get; set; }

    public Person(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Rating = 1;
    }
}