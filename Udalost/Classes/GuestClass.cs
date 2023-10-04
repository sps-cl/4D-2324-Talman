using System;
using EventApp.Exceptions;

namespace EventApp.Models {

    internal class Guest : Atendee<Guest> {

        public enum InvitationStatus {
            Denied, Pending, Accepted, None
        }

        public InvitationStatus invitationStatus = InvitationStatus.None;

        public Guest (string name, string surname, int age) : base(name, surname, age) {
        }

        public void processInvitation(bool accepted) {

            if (invitationStatus != InvitationStatus.None) {

                if (accepted) {
                    invitationStatus = InvitationStatus.Accepted;
                }
                else {
                    invitationStatus = InvitationStatus.Denied;
                }

            }
            else {
                throw new InvitationNotFoundException();
            }

        }

        public override void DisplayInfo() {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}, InvStatus: {invitationStatus}");
        }

    }

}