using System;

namespace LibraryApp.Exeptions {

    public class NotAvailableException : Exception  {
        public NotAvailableException(string message) : base(message) { 
        }
    }

    public class NotFoundException : Exception {
        public NotFoundException(string message = "Item not found") : base(message) {
        }
    }
}