using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.cladire
{
    public class Cladire
    {

        private string denumire;
        private int intrari;
        private int etaje;

        public Cladire()
        {
            Console.WriteLine("eu sunt constructorul cu 0 parametri din cladire");
        }

        public Cladire(string denumire,int intrari,int etaje)
        {
            this.denumire = denumire;
            this.intrari = intrari;
            this.etaje = etaje;
            Console.WriteLine("eu sunt constructorul cu 3 parametri din cladire");
        }

        public Cladire(string denumire)
        {
            Console.WriteLine("eu sunt constructorul cu 1 parametru din cladire");
            this.denumire = denumire;
        }

        public string getDenumire()
        {
            return this.denumire;
        }

        public void setDenumire(string denumire)
        {
            this.denumire=denumire;
        }

        public int getIntrari()
        {
            return this.intrari;
        }

        public void setIntrari(int intrari)
        {
            this.intrari=intrari;
        }

        public int getEtaje()
        {
            return this.etaje;
        }

        public void setEtaje(int etaje)
        {
            this.etaje=etaje;
        }

        public string descriere()
        {
            string text = "";

            text+="denumire: "+this.denumire+", ";
            text+="intrari: "+this.intrari+", ";
            text+="etaje:"+this.etaje;
            
            return text;
        }

    }
}
