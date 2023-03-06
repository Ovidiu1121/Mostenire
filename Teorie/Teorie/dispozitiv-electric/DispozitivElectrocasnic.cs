using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.dispozitiv_electric
{
    public class DispozitivElectrocasnic:DispozitivElectric
    {

        private int greutate;
        private string functie;
        private int consumDeEnergie;

        public DispozitivElectrocasnic()
        {

        }

        public DispozitivElectrocasnic(int greutate,string functie,int consumDeEnergie):base()
        {
            this.greutate = greutate;
            this.functie = functie;
            this.consumDeEnergie = consumDeEnergie;
        }

        public DispozitivElectrocasnic(string prop):base(prop)
        {
            string[] a = prop.Split(",");

            this.greutate=int.Parse(a[3]);
            this.functie = a[4];
            this.consumDeEnergie=int.Parse(a[5]);

        }

        public int Greutate
        {
            get { return this.greutate; }
            set { this.greutate = value;}
        }

        public string Functie
        {
            get { return this.functie; }
            set { this.functie = value; }
        }

        public int ConsumDeEnergie
        {
            get { return this.consumDeEnergie;}
            set { this.consumDeEnergie = value;}

        }

        public string disElectrocasnicDescriere()
        {

            string text = base.disElectricDescriere();

            text+="greutate: "+this.greutate+", ";
            text+="functie: "+this.functie+", ";
            text+="consum de energie: "+this.consumDeEnergie+", ";

            return text;

        }





    }
}
