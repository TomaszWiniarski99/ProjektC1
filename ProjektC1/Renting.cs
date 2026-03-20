namespace ProjektC1;

public class Renting
{
    public Person Renter { get; set; }
    public Item RentedItem { get; set; }
    public int Id { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public DateTime DueDate { get; set; }
    public double Penalty { get; set; }
    public bool IsReturned { get; set; }

    public static int IdCount { get; set; }

    public Renting(Person renter, Item rentedItem, int days)
    {
        Renter = renter;
        RentedItem = rentedItem;
        Id = IdCount++;
        RentDate = DateTime.Now;
        DueDate = RentDate.AddDays(days);
        IsReturned = false;
    }
    
    public void ReturnItem()
    {
        ReturnDate = DateTime.Now;
        IsReturned = true;
        if (ReturnDate > DueDate)
        {
            int lateDays = (ReturnDate.Value - DueDate).Days;
            Penalty = lateDays * 10;
        }
    }
}