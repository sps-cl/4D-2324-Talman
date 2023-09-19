using System;

namespace LibraryApp {

    internal abstract class LibraryItem<T> {

        private int id;
        public string Title {get;}
        public bool isAvailable {get;set;}

        public LibraryItem(int id, string Title) {
            this.id = id;
            this.Title = Title;
            this.isAvailable = isAvailable;
        }

        public int getId() {
            return id;
        }

        public abstract void DisplayInfo();
    }

    internal class Book : LibraryItem<Book> {

        public string Author {get;}

        public Book(int id, string Title, string Author) : base(id, Title) {
            this.Author = Author;
        }

        public override void DisplayInfo() {
            Console.WriteLine($"Title: {Title}, Autor: {Author}, Id: {getId()}");
        }
    }

    internal class DVD : LibraryItem<DVD> {

        public string Director {get;}

        public DVD (int id, string Title, string Director) : base(id, Title) {
            this.Director = Director;
        }

        public override void DisplayInfo() {
            Console.WriteLine($"Title: {Title}, Director: {Director}, Id: {getId()}");
        }
    }

    internal class Library {

        List<Book> bookShelf = new List<Book>();
        List<DVD> dvdShelf = new List<DVD>();


        public void AddBook(Book book) {
            bookShelf.Add(book);
        }

        public void removeBookById(int id) {
            for (int i = 0; i < bookShelf.Count; i++) {
                if (bookShelf[i].getId() == id) {
                    bookShelf.RemoveAt(i);
                }
            }
        }

        public void AddDVD(DVD dvd) {
            dvdShelf.Add(dvd);
        }

        public void removeDVDById(int id) {
            for (int i = 0; i < dvdShelf.Count; i++) {
                if (dvdShelf[i].getId() == id) {
                    dvdShelf.RemoveAt(i);
                }
            }
        }

        public void DisplayBooks() {
            foreach (var book in bookShelf) {
                book.DisplayInfo();
            }
        }

        public void DisplayDVDs() {
            foreach (var dvd in dvdShelf) {
                dvd.DisplayInfo();
            }
        }
    }
}