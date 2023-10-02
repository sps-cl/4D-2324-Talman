using System;

namespace LibraryApp {

    internal abstract class LibraryItem<T> {

        private int id;
        public string Title {get;}
        public bool isAvailable {get;set;}

        public LibraryItem(int id, string Title) {
            this.id = id;
            this.Title = Title;
            this.isAvailable = true;
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

    internal class Library<T> where T : LibraryItem<T> {

        List<T> shelf = new List<T>();

        public void AddItem(T item) {
            shelf.Add(item);
        }

        public void CheckoutItem (int id) {
            for (int i = 0; i < shelf.Count; i++) {
                if (shelf[i].getId() == id) {
                    if (shelf[i].isAvailable == true) {
                        shelf[i].isAvailable = false;
                        Console.WriteLine($"I have borrowed: {shelf[i].Title}");
                    }
                 }
            }
        }

        public void DisplayItems() {
            foreach (T item in shelf) {
                if (item.isAvailable == true) {
                    item.DisplayInfo();
                }
            }
        }
    }
}