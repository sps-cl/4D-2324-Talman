using System;

namespace EventApp.Exceptions {

    public class IncorrectGivenNameException : Exception {
        public IncorrectGivenNameException(string message = "Incorrect given name") : base(message) {
        }
    }

}