using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.proprietate
{
    internal class Apartament:Locuinta
    {

        private string orientation;
        private bool hasBalcony;

        public Apartament()
        {

        }

        public Apartament(string orientation,bool hasBalcony):base()
        {
            this.orientation = orientation;
            this.hasBalcony = hasBalcony;
           
        }

        public Apartament(string prop)
        {
            string[] a=prop.Split(",");
            
            this.orientation = a[6];
            this.hasBalcony = bool.Parse(a[7]);

        }

        public string Orientation
        {
            get { return this.orientation; }
            set { this.orientation = value; }
        }

        public bool HasBalcony
        {
            get { return this.hasBalcony;}
            set { this.hasBalcony = value;}
        }

        public string aparatamentDescription()
        {

            string text = base.locuintaDescription();

            text+="orientation: "+this.orientation+", ";
            text+="has balcony: "+this.hasBalcony;

            return text;    


        }


    }
}
