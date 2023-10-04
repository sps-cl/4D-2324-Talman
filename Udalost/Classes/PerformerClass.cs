using System;

namespace EventApp.Models {

    internal class Performer : Atendee<Performer> {
        
        public string job;

        public Performer (string name, string surname, int age, string job) : base(name, surname, age) {
            this.job = job;
        }

        public override void DisplayInfo() {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}, Job: {job}");
        }

    }

}