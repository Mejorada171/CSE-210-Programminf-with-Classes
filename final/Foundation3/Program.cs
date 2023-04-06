using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "10001");
        Address address2 = new Address("456 Oak Ave", "Los Angeles", "CA", "90001");

        Event event1 = new Lecture("Build your own business", "This event is going to help you build your first business, Mike O'Donnell the successful businessman from California is going to share his history of success in businesses and how you can do it as well", new DateTime(2023, 4, 15, 10, 0, 0), "1 hour", address1, "Mike O'Donnell", 50);
        Event event2 = new Reception("Become a professional chef", "This event is going to show the best techniques to be a professional cooker, Lisa Shawn professional chef in New York, owner of several restaurant around the world, is going to share the most amazing receipts and techniques with you.", new DateTime(2023, 4, 20, 19, 0, 0), "2 hour", address2, "email@example.com");
        Event event3 = new Outdoor("Trust yourself", "This event is going to help you to increase your self-confidence, Tom Brady the best football player of all the times is going to give you a lesson about self confidence as he said: It is you against you out there just do it", new DateTime(2023, 4, 25, 15, 0, 0), "3 hour", address1, "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine();
        Console.WriteLine(event1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine();
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine();
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(event2.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(event3.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine();
    }
}


