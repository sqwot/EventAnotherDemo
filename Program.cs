using System;

namespace EventAnotherDemo {

    class Program {
        public delegate void MyDelegate();
        public event MyDelegate Event;
        public event Action EventAction;
        static void Main() {
            Person person = new Person("Vasya");
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;

            person.TakeTime(DateTime.Parse("01.05.2019 21:13:01"));
            person.TakeTime(DateTime.Parse("01.05.2019 04:13:01"));


            Console.ReadKey();
        }

        private static void Person_DoWork(object sender, EventArgs e) {
            var prsn = (Person)sender;
            Console.WriteLine($"Hello, i am {prsn.Name}, and i go to my love work");
        }

        private static void Person_GoToSleep() {
            Console.WriteLine("I am go to sleep");
        }
    }

}