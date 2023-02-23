using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.cladire
{
    public class Scoala:Cladire
    {

        private string nume;
        private int saliClasa;
        private bool privata;

        public Scoala():base()
        {
            Console.WriteLine("eu sunt constructorul cu 0 parametri din scoala");
        }

        public Scoala(string nume,int saliClasa,bool privata,string denumire):base(denumire)
        {
            this.nume = nume;
            this.saliClasa = saliClasa;
            this.privata = privata;
            Console.WriteLine("eu sunt constructorul cu 4 parametri din scoala");
        }

        public Scoala(string nume,int saliClasa,string denumire,int intrari, int etaje) : base(denumire, intrari, etaje)
        {
            this.nume = nume;
            this.saliClasa = saliClasa;

            Console.WriteLine("eu sunt constructorul cu 5 parametri din scoala");
        }

        public Scoala(string denumire) : base(denumire)
        {
            Console.WriteLine("eu sunt constructorul cu 1 parametru din scoala");
        }

        public string getNume()
        {
            return this.nume;
        }

        public void setNume(string nume)
        {
            this.nume=nume;
        }

        public int getsaliClasa()
        {
            return this.saliClasa;
        }

        public void setSaliClasa(int saliClasa)
        {
            this.saliClasa=saliClasa;
        }

        public bool getPrivata()
        {
            return this.privata;
        }

        public void setPrivata(bool privata)
        {
            this.privata=privata;
        }

        public string descriere()
        {
            string text = "";

            text+="nume: "+this.nume+", ";
            text+="nr sali clasa: "+this.saliClasa+", ";
            text+="privata: "+this.privata;

            return text;
        }




    }
}
