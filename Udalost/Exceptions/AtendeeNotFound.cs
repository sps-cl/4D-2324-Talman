using System;

namespace EventApp.Exceptions {

    public class AtendeeNotFoundException : Exception {
        public AtendeeNotFoundException(string message = "Atendee not found") : base(message) {
        }
    }

}