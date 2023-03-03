using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.dispozitiv_electric
{
    public class Frigider:DispozitivElectrocasnic
    {
        private int rafturi;
        private int temperaturaMax;
        private bool areCongelator;

        public Frigider()
        {

        }

        public Frigider(int rafturi,int temperaturaMax,bool areCongelator):base()
        {
            this.rafturi = rafturi;
            this.temperaturaMax = temperaturaMax;
            this.areCongelator = areCongelator;
        }

        public Frigider(string prop)
        {
            string[] a = prop.Split(",");

            this.rafturi=int.Parse(a[6]);
            this.temperaturaMax=int.Parse(a[7]);
            this.areCongelator=bool.Parse(a[8]);

        }

        public int Rafturi
        {
            get { return this.rafturi; }
            set { this.rafturi = value; }
        }

        public int TemperaturaMax
        {
            get { return this.temperaturaMax; }
            set { this.temperaturaMax = value;}
        }

        public bool AreCongelator
        {
            get { return this.areCongelator;}
            set { this.areCongelator = value;}
        }

        public string frigiderDescriere()
        {
            string text = base.disElectrocasnicDescriere();

            text+="nr de rafturi: "+this.rafturi+", ";
            text+="temperatura max: "+this.temperaturaMax+", ";
            text+="are congelator: "+this.areCongelator;

            return text;

        }





    }
}
