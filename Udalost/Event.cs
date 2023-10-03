using System;
using EventApp.Exceptions;

namespace EventApp {


    internal abstract class Event<T> {

        public string name;
        public string description;

        List<Guest> guestList = new List<Guest>();

    }


    internal abstract class Atendee<T> {

        public string name;
        public string surname;
        public int age;

        public Atendee(string name, string surname, int age) {

            this.name = name;
            this.surname = surname;
            this.age = age;

        }

    }

    internal class Guest : Atendee<Guest> {

        public enum invitaionStatus {

            Denied, Pending, Accepted

        }

        public bool hasInvitation = false;
        public invitaionStatus acceptedInvitation = invitaionStatus.Pending;

        public Guest (string name, string surname, int age) : base(name, surname, age) {

        }
        public void processInvitation(bool accepted) {

            if (hasInvitation) {

                if (accepted) {

                    acceptedInvitation = invitaionStatus.Accepted;

                }
                else {

                    acceptedInvitation = invitaionStatus.Denied;

                }

            }
            else {

                throw new InvitationNotFoundException();

            }

        }

    }

    internal class Performer : Atendee {
        
    }

}