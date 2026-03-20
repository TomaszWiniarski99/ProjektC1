namespace ProjektC1;

public abstract class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public static int IdCounter { get; set; } = 0;
    
    public int MaxActiveRentals { get; set; }
    
    public UserType Type { get; set; }

    public Person(string firstName, string lastName)
    {
        Id = IdCounter++;
        FirstName = firstName;
        LastName = lastName;
    }
}