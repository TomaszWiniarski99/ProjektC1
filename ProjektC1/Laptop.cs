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
    public Laptop(int maxDays, double price, string name, double screen, double ram) : base(maxDays, price, name)
    {
        Screen = screen;
        Ram = ram;
    }
}