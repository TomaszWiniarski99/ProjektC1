namespace ProjektC1;

public abstract class Item
{
    public int MaxDays
    {
        get;
        set;
    }
    
    public double PricePerDay
    {
        get;
        set;
    }

    public string Name
    {
        get;
        set;
    }

    public int Id
    {
        get;
        set;
    }

    public Status ItemStatus
    {
        get;
        set;
    }

    private static int IdCount
    {
        get;
        set;
    } = 0;

    public Item(int maxDays, double pricePerDay, string name)
    {
        MaxDays = maxDays;
        PricePerDay = pricePerDay;
        Name = name;
        ItemStatus = Status.Available;
        Id = IdCount;
        IdCount++;
    }
}