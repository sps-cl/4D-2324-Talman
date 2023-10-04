using System;
using EventApp.Models;
using EventApp.Exceptions;

namespace EventApp {


    internal class Event {

        public string name;
        public string description;

        List<Performer> performerList = new List<Performer>();
        List<Guest> guestList = new List<Guest>();

        public Event(string name, string description) {
            this.name = name;
            this.description = description;
        }

        public void AddAtendee<T> (T atendee) {

            switch (atendee) {

                case Guest guest:
                    guestList.Add(guest);
                    guest.invitationStatus = Guest.InvitationStatus.Pending;
                    break;
                case Performer performer:
                    performerList.Add(performer);
                    break;
                default:
                    throw new IncorrectAtendeeObjectException();

            }

        }

        public void RemoveAtendee(string name, string surname) {

            if (name == null || surname == null) {
                throw new IncorrectGivenNameException();
            }

            try {

                Performer person = performerList.Find(person => person.name == name && person.surname == surname)!;

                if (person != null) {
                    performerList.Remove(person);
                }
                
            }
            catch (ArgumentNullException) {

                try {

                    Guest person = guestList.Find(person => person.name == name && person.surname == surname)!;

                    if (person != null) {
                        guestList.Remove(person);
                    }
                }
                catch (ArgumentNullException) {
                    throw new AtendeeNotFoundException();
                }

            }

        }

        public void DisplayGuests() {

            foreach (var guest in guestList) {
                guest.DisplayInfo();
            }

        }

        public void DisplayPerformers() {

            foreach (var performer in performerList) {
                performer.DisplayInfo();
            }

        }

    }

}