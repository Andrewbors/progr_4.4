using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Teacher : People
    {
        private String Position;
        private String Cathedra;
        private String Place;

        public String GetPosition() 
        {
            return Position;
        }

        public String GetCathedra() 
        {
            return Cathedra;
        }

        public String GetPlace() 
        {
            return Place;
        }

        public void SetPosition(String Position) 
        {
            this.Position = Position;
        }

        public void SetCathedra(String Cathedra) 
        {
            this.Cathedra = Cathedra;
        }

        public void SetPlace(String Place) 
        {
            this.Place = Place;
        }

        public Teacher() {
        }

        public Teacher(String Position, String Cathedra, String Place) {
            this.Position = Position;
            this.Cathedra = Cathedra;
            this.Place = Place;
        }

        public Teacher(String Name, String SecondName, String Birthday, String Position, String Cathedra, String Place) 
        : base(Name, SecondName, Birthday) {
            this.Position = Position;
            this.Cathedra = Cathedra;
            this.Place = Place;
        }

        public Teacher(Teacher Teacher)
        {   
            this.Position = Teacher.GetPosition();
            this.Cathedra = Teacher.GetCathedra();
            this.Place = Teacher.GetPlace();
        }

        public override void ShowInfo() 
        {
            Console.WriteLine(Position);
            Console.WriteLine(Cathedra);
            Console.WriteLine(Place);
        }
    }
}
