

using Microsoft.VisualBasic;
using Reiseplanlegging;

class program
{
    static void Main()
    {
        var destination1 = new Destination("Oslo", "Norways biggest city");
        var destination2 = new Destination("Tokyo", "Beautiful City");

        destination1.AddService(new TravelService("Fligth"));
        destination1.AddService(new TravelService("City Tour")); 
        
        destination2.AddService(new TravelService("Bullet Train"));
        destination2.AddService(new TravelService("BBQ cooking class"));

        Console.WriteLine("All Destination and Their Available Service:");
        destination1.DestinationInfo();
        Console.WriteLine();
        destination2.DestinationInfo();

        var travel1 = new Travel(1, DateTime.Now.AddDays(10));
        travel1.AddService(new TravelService("Hotel Stay"));
        travel1.AddService(new TravelService("Guide Excursion")); 

        travel1.TravelInfo();

        Console.WriteLine("\nCancelling Travel...");
        travel1 = null;

        Console.WriteLine("\nTravel Report: ");

    }
}