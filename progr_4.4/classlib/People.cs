using System;

namespace ClassLibrary
{
    public class People
    {
        private String Name;
        private String SecondName;
        private String Birthday;

        public String GetName() {
            return Name;
        }

        public String GetSecondName() {
            return SecondName;
        }

        public String GetBirthday() {
            return Birthday;
        }

        public void SetName(String name) {
            this.Name = Name;
        }

        public void SetSecondName(String lastName) {
            this.SecondName = SecondName;
        }

        public void SetBirthday(String Birthday) {
            this.Birthday = Birthday;
        }

        public People() { 
        }

        public People(String Name, String SecondName) {
            this.Name = Name;
            this.SecondName = SecondName;
        }   

        public People(String Name, String SecondName, String Birthday) {
            this.Name = Name;
            this.SecondName = SecondName;
            this.Birthday = Birthday;
        }

        public People(People People) {
            this.Name = People.GetName();
            this.SecondName = People.GetSecondName();
            this.Birthday = People.GetBirthday();
        }


        public virtual void ShowInfo() {   
            Console.Write("Name: ");
            Console.WriteLine(Name);
            Console.Write("Second name: ");
            Console.WriteLine(SecondName);
            Console.Write("Birthday: ");
            Console.WriteLine(Birthday);    
        }
    }
}
