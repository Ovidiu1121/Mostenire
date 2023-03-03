using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.proprietate
{
    public class Veh:Proprietate
    {
        private string brand;
        private string fuel;
        private string transmission;

        public Veh()
        {

        }

        public Veh(string brand,string fuel,string transmission):base()
        {
            this.brand = brand;
            this.fuel = fuel;
            this.transmission = transmission;
        }

        public Veh(string prop)
        {
            string[] a = prop.Split(",");

            this.brand = a[3];
            this.fuel = a[4];
            this.transmission = a[4];


        }

        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }

        public string Fuel
        {
            get { return this.fuel; }
            set { this.fuel = value; }
        }

        public string Transmission
        {
            get { return this.transmission; }
            set { this.transmission = value; }
        }

        public string vehiculDescription()
        {

            string text = base.proprietateDescription();

            text+="brand: "+this.brand+", ";
            text+="fuel: "+this.fuel+", ";
            text+="transmission: "+this.transmission;

            return text;

        }

    }
}
