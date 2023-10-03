using System;

namespace EventApp.Exceptions {

    public class EventNotFoundException : Exception {
        public EventNotFoundException(string message = "Event not found") : base(message) {
        }
    }

}