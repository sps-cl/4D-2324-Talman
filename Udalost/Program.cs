using System;
using EventApp;

public class Program {

    public static void Main(string[] args) {
        
        Guest guest = new Guest("John", "Rock", 45);

        Console.WriteLine(guest.name);
        
    }

}