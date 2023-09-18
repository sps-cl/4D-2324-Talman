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
            Console.WriteLine($"Autor: {Author}, Title: {Title}");
        }
    }

    internal class DVD : LibraryItem<DVD> {
        public string Director {get;}

        public DVD (string Director, int id, string Title) : base(id, Title) {
            this.Director = Director;
        }

        public override void DisplayInfo() {
            Console.WriteLine($"Director: {Director}, Title: {Title}");
        }
    }

    internal class Shelf {
        List<Book> bookShelf = new List<Book>();
        List<DVD> dvdShelf = new List<DVD>();

        public void addItem (ref LibraryItem item) {
            if (item is Book) {
                bookShelf.Add((Book)item);
            } else if (item is DVD) {
                dvdShelf.Add((DVD)item);
            }
        }
    }


    internal class Library {

        
        
    }
}

