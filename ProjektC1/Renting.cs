namespace ProjektC1;

public class Renting
{
    public Person Renter { get; set; }
    public Item RentedItem { get; set; }
    public int Id { get; set; }
    public int DaysRented { get; set; } = 0;

    public static int IdCount { get; set; }

    public Renting(Person Renter, Item RentedItem)
    {
        this.Renter = Renter;
        this.RentedItem = RentedItem;
        Id = IdCount;
        IdCount++;
    }
}