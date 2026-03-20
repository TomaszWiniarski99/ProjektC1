namespace ProjektC1;

public class Camera : Item
{
    public double Memory
    {
        get;
        set;
    }

    public string Lens
    {
        get;
        set;
    }
    public Camera(int maxDays, double price, string brand, double memory, string lens) : base(maxDays, price, brand)
    {
        Memory = memory;
        Lens = lens;
    }
}