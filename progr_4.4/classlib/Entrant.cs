using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Entrant : People
    {
        public int ZNOPoints;
        private int DocPoints;
        private String PlaceName;


        public int GetZNOPoints() {
            return ZNOPoints;
        }

        public int GetDocPoints() {
            return DocPoints;
        }

        public String GetPlaceName() {
            return PlaceName;
        }

        public void SetZNOPoints(int ZNOPoints) {
            this.ZNOPoints = ZNOPoints;
        }

        public void SetDocPoints(int DocPoints) {
            this.DocPoints = DocPoints;
        }

        public void SetZNOPoints(String PlaceName) {
            this.PlaceName = PlaceName;
        }

        public Entrant() {
        }

        public Entrant(String Name, String SecondName, string Birthday, int ZNOPoints, int documentPoints, String schoolName) 
        : base(Name, SecondName, Birthday) {
            this.ZNOPoints = ZNOPoints;
            this.DocPoints = DocPoints;
            this.PlaceName = PlaceName;
        }

        public Entrant(Entrant Entrant) {
            this.ZNOPoints = Entrant.GetZNOPoints();
            this.DocPoints = Entrant.GetDocPoints();
            this.PlaceName = Entrant.GetPlaceName();
        }

        public Entrant(int ZNOPoints, int DocPoints, String PlaceName) {
            this.ZNOPoints = ZNOPoints;
            this.DocPoints = DocPoints;
            this.PlaceName = PlaceName;
        }

        public override void ShowInfo() {
            Console.WriteLine(ZNOPoints);
            Console.WriteLine(DocPoints);
            Console.WriteLine(PlaceName);
        }

    }
}
