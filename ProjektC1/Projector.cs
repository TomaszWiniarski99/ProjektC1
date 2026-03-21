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
    public Projector(int maxDays, double price, string name, double weight, double range) : base(maxDays, price, name)
    {
        Weight = weight;
        Range = range;
    }
}