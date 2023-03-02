using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.proprietate
{
    public class Casa:Locuinta
    {
        private int rooms;
        private int yardSize;
        private bool hasGarage;

        public Casa():base()
        {

        }

        public Casa(int rooms,int yardsSize,bool hasGarage):base()
        {
            this.rooms = rooms;
            this.yardSize = yardsSize;
            this.hasGarage = hasGarage;
        }

        public Casa(string prop)
        {
            string[] a = prop.Split(",");

            this.rooms=int.Parse(a[6]);
            this.yardSize=int.Parse(a[7]);
            this.hasGarage=bool.Parse(a[8]);
        }

        public int Rooms
        {
            get { return this.rooms; }
            set { this.rooms = value; }
        }

        public int YardSize
        {
            get { return this.yardSize; }
            set { this.yardSize = value;
            }
        }

        public bool HasGarage
        {
            get { return this.HasGarage; }
            set { this.HasGarage=value; }
        }

        public string casaDescription()
        {
            string text = base.locuintaDescription();

            text+="number of rooms: "+this.rooms+", ";
            text+="yard size: "+this.yardSize+", ";
            text+="has garage: "+this.hasGarage;

            return text;

        }

    }
}
