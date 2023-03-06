using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.dispozitiv_electric
{
    public class DispozitivElectronic:DispozitivElectric
    {

        private string software;
        private string functie;
        private int memorie;

        public DispozitivElectronic()
        {

        }

        public DispozitivElectronic(string software,string functie,int memorie):base()
        {
            this.software = software;
            this.functie = functie;
            this.memorie = memorie;
        }

        public DispozitivElectronic(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.software=a[3];
            this.functie = a[4];
            this.memorie=int.Parse(a[5]);

        }

        public string Software
        {
            get { return this.software; }
            set { this.software = value; }
        }

        public string Functie
        {
            get { return this.functie; }
            set { this.functie = value; }
        }

        public int Memorie
        {
            get { return this.memorie;}
            set { this.memorie = value;}

        }

        public string disElectronicDescriere()
        {

            string text = base.disElectricDescriere();

            text+="spftware: "+this.software+", ";
            text+="functie: "+this.functie+", ";
            text+="memorie: "+this.memorie+", ";

            return text;

        }

    }
}
