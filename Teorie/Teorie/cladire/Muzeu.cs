using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.cladire
{
    public class Muzeu:Cladire
    {
        private string nume;
        private int nrExponate;
        private int anInfiintare;

        public Muzeu():base()
        {
            Console.WriteLine("eu sunt constructorul cu 0 parametri din muzeu");
        }

        public Muzeu(string nume,int nrExponate,int anInfiintare,string denumire):base(denumire)
        {
            this.nume = nume;
            this.nrExponate = nrExponate;
            this.anInfiintare = anInfiintare;
            Console.WriteLine("eu sunt constructorul cu 4 parametri din muzeu");
        }

        public Muzeu(string nume):base()
        {
            this.nume=nume;
            Console.WriteLine("eu sunt constructorul cu 1 parametru din muzeu");
        }

        public Muzeu(string nume, int nrExponate, int anInfiintare,string denumire,int intrari,int etaje) : base(denumire, intrari, etaje)
        {
            this.nume = nume;
            this.nrExponate = nrExponate;
            this.anInfiintare = anInfiintare;
            Console.WriteLine("eu sunt constructorul cu 6 parametri din muzeu");
        }

        public string getNume()
        {
            return this.nume;

        }

        public void setNume(string nume)
        {
            this.nume=nume;
        }

        public int getNrExponate()
        {
            return this.nrExponate;
        }

        public void setNrExponate(int nrExponate)
        {
            this.nrExponate=nrExponate;
        }

        public int getAnInfiintare()
        {
            return this.anInfiintare;
        }

        public void setAnInfiintare(int anInfiintare)
        {
            this.anInfiintare=anInfiintare;
        }

        public string descriere()
        {
            string text = base.descriere()+"\n";

            text+="nume: "+this.nume+", ";
            text+="nr Exponate: "+this.nrExponate+", ";
            text+="an infiintare: "+this.anInfiintare;

            return text;
        }


    }
}
