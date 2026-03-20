namespace ProjektC1;

public class Laptop : Item
{
    public double Screen
    {
        get;
        set;
    }

    public double Ram
    {
        get;
        set;
    }
    public Laptop(int maxDays, double price, string brand, double screen, double ram) : base(maxDays, price, brand)
    {
        Screen = screen;
        Ram = ram;
    }
}