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

    public string Brand
    {
        get;
        set;
    }

    public int DaysRented
    {
        get;
        set;
    }

    public int Id
    {
        get;
        set;
    }

    public bool Available
    {
        get;
        set;
    }

    private static int IdCount
    {
        get;
        set;
    } = 0;

    public Item(int maxDays, double price, string brand)
    {
        this.MaxDays = maxDays;
        this.Price = price;
        this.DaysRented = 0;
        this.Brand = brand;
        this.Id = IdCount;
        IdCount++;
    }
}