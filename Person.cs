using System;


namespace EventAnotherDemo {

    class Person {
        public event Action GoToSleep = () => { };
        public event EventHandler DoWork = (x,y) => { };
        public string Name { get; set; }
        public Person(string name) {
            this.Name = name;
        }
        public void TakeTime(DateTime now) {
            if(now.Hour <= 8) {
                GoToSleep.Invoke();
            }else {
                var args = new EventArgs();
                DoWork.Invoke(this, args);
            }
        }
    }
}
