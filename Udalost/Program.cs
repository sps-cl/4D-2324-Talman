using System;
using EventApp;
using EventApp.Models;

public class Program {

    public static void Main(string[] args) {
        
        Guest guest1 = new Guest("John", "Smith", 45);
        Guest guest2 = new Guest("Emily", "Johnson", 23);
        Guest guest3 = new Guest("Liam", "Carter", 61);
        Guest guest4 = new Guest("Harvey", "Lind", 20);

        Performer performer1 = new Performer("Ava", "Brown", 24, "singer");
        Performer performer2 = new Performer("Noah", "Brown", 21, "drummer");
        Performer performer3 = new Performer("Mia", "Harris", 29, "guitarist");

        Event event1 = new Event("Fireside", "A big music festival");

        event1.AddAtendee(guest1);
        event1.AddAtendee(guest2);
        event1.AddAtendee(guest3);

        event1.AddAtendee(performer1);
        event1.AddAtendee(performer2);
        event1.AddAtendee(performer3);
        
        guest1.processInvitation(true);
        guest2.processInvitation(false);

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
        Console.WriteLine("");

        event1.RemoveAtendee("Awa", "Brown");
        event1.RemoveAtendee("Harvey", "Lind");

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
    }

}