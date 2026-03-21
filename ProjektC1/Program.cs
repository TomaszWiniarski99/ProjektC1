namespace ProjektC1;

class Program
{
    static void Main(string[] args)
    {
        Service service = new Service();

        //Person
        Student student = new Student("Jan", "Kowalski", "Informatyka", 1, 2);
        Employee employee = new Employee("Anna", "Nowak", "IT");

        service.AddUser(student);
        service.AddUser(employee);

        //Item
        Laptop laptop = new Laptop(3, 10.5,  "Dell", 15.6, 16);
        Camera camera = new Camera(5, 9.0, "Nikon", 128, "Zoom");
        Projector projector = new Projector(2, 6.5, "Benq", 3, 10);

        service.AddItem(laptop);
        service.AddItem(camera);
        service.AddItem(projector);

        // --- Lista dostępnego sprzętu ---
        Console.WriteLine("Dostępny sprzęt:");
        foreach (Item item in service.GetAllAvailableItems())
        {
            Console.WriteLine($"{item.Id} - {item.Name} ({item.ItemStatus})");
        }

        //Rent item
        Console.WriteLine("\nWypożyczenie laptopa przez studenta");
        service.RentItem(student, laptop, 3);

        //Overdue
        Console.WriteLine("\nTest limitu wypożyczeń:");
        try
        {
            service.RentItem(student, camera, 3);
            service.RentItem(student, projector, 2);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Za dużo wypożyczeń");
        }

        //Active rentals-
        Console.WriteLine("\nAktywne wypożyczenia studenta:");
        List<Renting> rentals = service.GetUserRentals(student);
        foreach (Renting r in rentals)
        {
            Console.WriteLine($"{r.RentedItem.Name} do {r.DueDate}");
        }

        // --- Lista przeterminowanych ---
        Console.WriteLine("\nPrzeterminowane:");
        List<Renting> overdue = service.GetOverdueRentals();
        foreach (Renting r in overdue)
        {
            Console.WriteLine($"{r.RentedItem.Name} użytkownik: {r.Renter.FirstName}");
        }

        //Return
        Renting renting = service.GetUserRentals(student).First();

        service.Return(renting.Id);

        Console.WriteLine($"Kara: {renting.Penalty}");

        //Mark as unavailabla
        Console.WriteLine("\nOznaczanie projektora jako uszkodzony...");
        service.MarkAsUnavailable(projector);

        //Report
        Console.WriteLine("\nRaport:");
        Console.WriteLine(service.GenerateReport());
    }
}