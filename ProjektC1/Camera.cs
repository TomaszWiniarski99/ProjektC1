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
    public Camera(int maxDays, double price, string name, double memory, string lens) : base(maxDays, price, name)
    {
        Memory = memory;
        Lens = lens;
    }
}