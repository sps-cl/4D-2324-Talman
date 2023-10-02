using System;

namespace EventApp {

    internal abstract class Atendee <T> {

        public string name;
        public int age;
        public string gender;
        public Invitation invitation;

        public Atendee(string name, int age, string gender) {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        private bool AcceptInvitation (bool accept) {
            if (invitation != null) {

            }
        }

    }


    public class Invitation {

        public Event toEvent; 
        public bool accepted;

        public Invitation(Event toEvent) {
            this.toEvent = toEvent;
        }

    }


    internal abstract class Event {

        public enum EventType {
            Wedding, Concert, GarageSale
        };

        public EventType eventType;
        public string name;
        public string description;

        public Event (EventType type, string name, string description) {
            this.type = type;
            this.name = name;
            this.description = description;
        }

    }



}