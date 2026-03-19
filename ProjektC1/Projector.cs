namespace ProjektC1;

public class Projector : Item
{
    public double Weight
    {
        get;
        set;
    }

    public double Range
    {
        get;
        set;
    }
    public Projector(int maxDays, double price, string brand, double weight, double range) : base(maxDays, price, brand)
    {
        this.Weight = weight;
        this.Range = range;
    }
}