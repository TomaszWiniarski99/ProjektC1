namespace ProjektC1;

public abstract class Item
{
    public int MaxDays
    {
        get;
        set;
    }
    
    public double Price
    {
        get;
        set;
    }

    public int DaysRented
    {
        get;
        set;
    }

    public Item(int maxDays, double price)
    {
        this.MaxDays = maxDays;
        this.Price = price;
        this.DaysRented = 0;
    }
}