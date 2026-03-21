namespace ProjektC1;

public class Service
{
    private List<Person> users = new List<Person>();
    private List<Item> items = new List<Item>();
    private List<Renting> rentings = new List<Renting>();
    
    public void AddUser(Person user)
    {
        users.Add(user);
    }
    
    public void AddItem(Item item)
    {
        items.Add(item);
    }
    
    public List<Item> GetAllItems()
    {
        return items;
    }
    
    public List<Item> GetAllAvailableItems()
    {
        return items.Where(i => i.ItemStatus == Status.Available).ToList();
    }
    
    public void RentItem(Person user, Item item, int days)
    {
        if (item.ItemStatus != Status.Available)
            throw new Exception("Sprzęt niedostępny");

        int activeRentals = rentings.Count(r => r.Renter == user && !r.IsReturned);

        if (activeRentals >= user.MaxActiveRentals)
            throw new Exception("Przekroczono limit wypożyczeń");

        if (days > item.MaxDays)
            throw new Exception("Przekroczono maksymalny czas wypożyczenia");

        Renting renting = new Renting(user, item, days);
        rentings.Add(renting);

        item.ItemStatus = Status.Rented;
    }
    
    public void Return(int rentingId)
    {
        Renting renting = rentings.FirstOrDefault(r => r.Id == rentingId);

        if (renting == null)
            throw new Exception("Nie znaleziono wypożyczenia");

        if (renting.IsReturned)
            throw new Exception("Sprzęt już został zwrócony");

        renting.ReturnItem();
        renting.RentedItem.ItemStatus = Status.Available;
    }
    
    public void MarkAsUnavailable(Item item)
    {
        item.ItemStatus = Status.Unavailable;
    }
    
    public List<Renting> GetUserRentals(Person user)
    {
        return rentings.Where(r => r.Renter == user && !r.IsReturned).ToList();
    }
    
    public List<Renting> GetOverdueRentals()
    {
        return rentings.Where(r => !r.IsReturned && DateTime.Now > r.DueDate).ToList();
    }
    
    public string GenerateReport()
    {
        int totalItems = items.Count;
        int available = items.Count(i => i.ItemStatus == Status.Available);
        int rented = items.Count(i => i.ItemStatus == Status.Rented);
        int unavailable = items.Count(i => i.ItemStatus == Status.Unavailable);

        int activeRentals = rentings.Count(r => !r.IsReturned);
        int overdue = GetOverdueRentals().Count;

        return $"--- RAPORT ---\n" +
               $"Wszystkie sprzęty: {totalItems}\n" +
               $"Dostępne: {available}\n" +
               $"Wypożyczone: {rented}\n" +
               $"Niedostępne: {unavailable}\n" +
               $"Aktywne wypożyczenia: {activeRentals}\n" +
               $"Przeterminowane: {overdue}";
    }
}