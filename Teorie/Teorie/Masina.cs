using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie
{
    public  class Masina : Vehicul
    {
        private int scaune;
        private int caiPutere;
        private string combustibil;

        public Masina():base(1993)
        {
            Console.WriteLine("eu sunt constructorul cu 0 parametri din masina");

        }

        public Masina(string brand, int year, bool sport,int scaune,int caiPutere,string combustibil):base(brand,year,sport)
        {
            Console.WriteLine("eu sunt constructorul cu 3 parametri din masina");
            this.scaune = scaune;
            this.caiPutere = caiPutere;
            this.combustibil = combustibil;

        }

        public Masina(int scaune, int caiPutere):base(1234)
        {
            Console.WriteLine("eu sunt constructorul cu 2 parametri din masina");
            this.scaune = scaune;
            this.caiPutere = caiPutere;
        }

        public int getScaune()
        {
            return this.scaune;
        }

        public void setScaune(int scaune)
        {
            this.scaune= scaune;
        }

        public int getCaiPutere()
        {
            return this.caiPutere;
        }

        public void setCaiputere(int caiPutere)
        {
            this.caiPutere= caiPutere;
        }

        public string getCombustibil()
        {
            return this.combustibil;
        }

        public void setCombustibil(string combustibil)
        {
            this.combustibil= combustibil;
        }

        public string descriereMasina()
        {
            string text = base.descriereVehicul()+"\n";

            text+=this.scaune+" - scaune, ";
            text+=this.caiPutere+" - cai putere, ";
            text+=this.combustibil+" - combustibil ";

            return text;
        }


    }
}
