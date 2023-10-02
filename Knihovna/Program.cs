using System;
using LibraryApp;

public class Program {
    public static void Main(string[] args) {
        
        Book book1 = new Book(1, "The Hobbit", "J.R.Tolkien");
        Book book2 = new Book(2, "The Lord of the Rings", "J.R.Tolkien");
        Book book3 = new Book(3, "The Harry Potter", "J.K.Rowling");

        DVD dvd1 = new DVD(1, "Shrek", "Andrew Adamson");
        DVD dvd2 = new DVD(2, "Your Name", "Makoto Shinkai");
        DVD dvd3 = new DVD(3, "Weathering with you", "Makoto Shinkai");

        Library <Book> BookStore = new Library<Book>();
        Library <DVD> DVDStore = new Library<DVD>();

        BookStore.AddItem(book1);
        BookStore.AddItem(book2);
        BookStore.AddItem(book3);

        DVDStore.AddItem(dvd1);
        DVDStore.AddItem(dvd2);
        DVDStore.AddItem(dvd3);

        BookStore.CheckoutItem(3);
        DVDStore.CheckoutItem(1);

        BookStore.DisplayItems();
        DVDStore.DisplayItems();
    }
}