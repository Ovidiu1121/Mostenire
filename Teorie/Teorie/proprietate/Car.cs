using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.proprietate
{
    public class Car:Veh
    {

        private int manufacturingYear;
        private int horsePower;
        private int doors;

        public Car()
        {

        }

        public Car(int manufactoringYear,int horsePower,int doors):base()
        {
            this.manufacturingYear = manufactoringYear;
            this.horsePower = horsePower;
            this.doors = doors;
        }

        public Car(string prop):base(prop)
        {
            string[] a=prop.Split(",");

            this.manufacturingYear=int.Parse(a[6]);
            this.horsePower=int.Parse(a[7]);
            this.doors=int.Parse(a[8]);

        }

        public int ManufacturingYear
        {
            get { return this.manufacturingYear;}
            set { this.manufacturingYear = value;}
        }

        public int HoursePower
        {
            get { return this.horsePower;}
            set { this.horsePower = value;}
        }

        public int Doors
        {
            get { return this.doors; }
            set { this.doors = value; }
        }

        public string masinaDescription()
        {

            string text = base.vehiculDescription();

            text+="manufactoring year: "+this.manufacturingYear+", ";
            text+="hourse power: "+this.horsePower+", ";
            text+="number of doors: "+this.doors;

            return text;

        }

    }
}
