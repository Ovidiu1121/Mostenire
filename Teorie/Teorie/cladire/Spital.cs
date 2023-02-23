using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.cladire
{
    public class Spital:Cladire
    {
        private string nume;
        private int doctori;
        private int pacienti;

        public Spital() : base()
        {
            Console.WriteLine("eu sunt constructorul cu 0 parametri din spital");
        }

        public Spital(string nume, string denumire):base(denumire)
        {
            this.nume = nume;
            Console.WriteLine("eu sunt constructorul cu 2 parametri din spital");
        }

        public Spital(int doctori, int pacienti,string denumire,int intrari, int nrEtaje) : base(denumire,intrari,nrEtaje)
        {
            this.doctori = doctori;
            this.pacienti = pacienti;

            Console.WriteLine("eu sunt constructorul cu 5 parametri din spital");
        }

        public string getNume()
        {
            return this.nume;
        }

        public void setNume(string nume)
        {
            this.nume= nume;
        }

        public int getDoctori()
        {
            return this.doctori;
        }

        public void setDoctori(int doctori)
        {
            this.doctori= doctori;
        }

        public int getPacienti()
        {
            return this.pacienti;
        }

        public void setPacienti(int pacienti)
        {
            this.pacienti= pacienti;
        }

        public string descriere()
        {
            string text = base.descriere()+"\n";

            text+="nume: "+this.nume+", ";
            text+="doctori: "+this.doctori+", ";
            text+="pacienti: "+this.pacienti;

            return text;
        }



    }
}
