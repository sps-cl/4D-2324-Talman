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

        Library library = new Library();

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        library.AddDVD(dvd1);
        library.AddDVD(dvd2);
        library.AddDVD(dvd3);

        library.removeBookById(3);
        library.removeDVDById(1);

        library.DisplayBooks();
        library.DisplayDVDs();

    }
}