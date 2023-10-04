using System;

namespace EventApp.Models {

    internal abstract class Atendee<T> {

        public string name;
        public string surname;
        public int age;

        public Atendee(string name, string surname, int age) {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public abstract void DisplayInfo();
        
    }

}