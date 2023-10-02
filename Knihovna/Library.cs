using System;
using LibraryApp.Exeptions;

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
            
            T ItemToCheckout = shelf.Find(item => item.getId() == id);

            if (ItemToCheckout != null) {

                if (ItemToCheckout.isAvailable) {
                ItemToCheckout.isAvailable = false;
                Console.WriteLine($"I have borrowed: {ItemToCheckout.Title}");
                }
                else {
                    throw new NotAvailableException($"{ItemToCheckout.Title} is not available");
                }
            }
            else {  
                throw new NotFoundException();
            }
        }

        public void ReturnItem (int id) {
            
            T ItemToReturn = shelf.Find(item => item.getId() == id);

            if (ItemToReturn != null) {

                if (ItemToReturn.isAvailable == false) {
                ItemToReturn.isAvailable = true;
                Console.WriteLine($"I have returned: {ItemToReturn.Title}");
                }
                else {
                    throw new NotAvailableException($"{ItemToReturn.Title} is already available");
                }
            }
            else {  
                throw new NotFoundException();
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