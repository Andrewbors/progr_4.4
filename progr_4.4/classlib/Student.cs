using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student : People
    {
        private int Course;
        private String Group;
        private String Faculty;
        private String Place;
        
        public int GetCourse() {
            return Course;
        }

        public String GetGroup() {
            return Group;
        }

        public String GetFaculty() {
            return Faculty;
        }

        public String GetPlace() {
            return Place;
        }

        public void SetCourse(int Course) {
            this.Course = Course;
        }

        public void SetGroup(String Group) {
            this.Group = Group;
        }

        public void SetFaculty (String Faculty) {
            this.Faculty = Faculty;
        }

        public void SetPlace(String Place) {
            this.Place = Place;
        }

        public Student() {
        }

        public Student(int Course, String Group, String Faculty, String Place) {    
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.Place = Place;   
        }

        public Student(String Name, String SecondName, String Birthday, int Course, String Group, String Faculty, String Place) 
        : base(Name, SecondName, Birthday) {
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.Place = Place;   
        }
    
        public Student(Student Student) {
            this.Course = Student.GetCourse();
            this.Group = Student.GetGroup();
            this.Faculty = Student.GetFaculty();
            this.Place = Student.GetPlace(); 
        }

        public override void ShowInfo() {
            Console.WriteLine(Course);
            Console.WriteLine(Group);
            Console.WriteLine(Faculty);
            Console.WriteLine(Place);
        }
    }
}
