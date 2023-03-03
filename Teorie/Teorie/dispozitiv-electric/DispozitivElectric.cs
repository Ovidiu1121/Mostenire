using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.dispozitiv_electric
{
    public class DispozitivElectric
    {
        private string type;
        private int pret;
        private string marca;

        public DispozitivElectric()
        {

        }

        public DispozitivElectric(string type,int pret,string marca)
        {
            this.type = type;
            this.pret = pret;
            this.marca = marca;
        }

        public DispozitivElectric(string prop)
        {
            string[] a = prop.Split(",");

            this.type=a[0];  
            this.pret = int.Parse(a[1]);
            this.marca = a[2];
        }

        public string Type
        {
            get { return this.type; }
            set { this.type=value; }
        }

        public int Pret
        {
            get { return this.pret; }
            set { this.pret=value; }
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca=value; }
        }

        public string disElectricDescriere()
        {
            string text = "";

            text+="type: "+this.type+", ";
            text+="pret: "+this.pret+", ";
            text+="marca: "+this.Marca+", ";

            return text;
        }


    }
}
