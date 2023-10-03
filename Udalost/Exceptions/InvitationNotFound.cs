using System;

namespace EventApp.Exceptions {

    public class InvitationNotFoundException : Exception {
        public InvitationNotFoundException(string message = "Invitation not found") : base(message) {
        }
    }

}