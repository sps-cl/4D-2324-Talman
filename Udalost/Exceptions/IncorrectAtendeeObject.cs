using System;

namespace EventApp.Exceptions {

    public class IncorrectAtendeeObjectException : Exception {
        public IncorrectAtendeeObjectException(string message = "Invalid Atendee type") : base(message) {
        }
    }

}