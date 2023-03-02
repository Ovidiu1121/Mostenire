using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.dispozitiv_electric
{
    public class Televizor:DispozitivElectronic
    {

        private int programe;
        private int rezolutie;
        private string tipEcran;

        public Televizor()
        {

        }

        public Televizor(int programe,int rezolutie,string tipEcran):base()
        {
            this.programe = programe;
            this.rezolutie = rezolutie;
            this.tipEcran = tipEcran;
        }

        public Televizor(string prop)
        {
            string[] a = prop.Split(",");

            this.programe=int.Parse(a[6]);
            this.rezolutie=int.Parse(a[7]);
            this.tipEcran=a[8];

        }

        public int Programe
        {
            get { return this.programe; }
            set { this.programe = value; }
        }

        public int Rezolutie
        {
            get { return this.rezolutie; }
            set { this.rezolutie = value;}
        }

        public string TipEcran
        {
            get { return this.tipEcran;}
            set { this.tipEcran = value;}
        }

        public string televizorDescriere()
        {
            string text = base.disElectronicDescriere();

            text+="nr programe: "+this.programe+", ";
            text+="rezolutie: "+this.rezolutie+", ";
            text+="tip ecran: "+this.tipEcran;

            return text;
        }
    }
}
