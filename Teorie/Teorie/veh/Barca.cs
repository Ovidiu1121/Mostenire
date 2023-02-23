using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie
{
    public class Barca : Vehicul
    {

        private bool cuMotor;
        private int caiPutere;
        private string culoare;

        public Barca()
        {
            Console.WriteLine("constructor cu 0 parametri din barca");
        }

        public Barca(bool cuMotor, int caiPutere, string culoare,string brand,int year,bool sport) : base(brand, year, sport)
        {

            Console.WriteLine("constructor cu 3 parametri din barca");
            this.cuMotor = cuMotor;
            this.caiPutere = caiPutere;
            this.culoare = culoare;

        }

        public Barca(bool cuMotor)
        {

            Console.WriteLine("constructor cu 1 parametru din barca");
            this.cuMotor = cuMotor;

        }

        public Barca(bool cuMotor, int caiPutere)
        {

            Console.WriteLine("constructor cu 2 parametri din barca");
            this.cuMotor = cuMotor;
            this.caiPutere = caiPutere;

        }

        public bool getCuMotor()
        {
            return this.cuMotor;
        }

        public void setCuMotor(bool cuMotor)
        {
            this.cuMotor=cuMotor;
        }

        public int getCaiPutere()
        {
            return this.caiPutere;
        }

        public void setCaiputere(int caiPutere)
        {
            this.caiPutere= caiPutere;
        }

        public string getCuloare()
        {
            return this.culoare;
        }

        public void setCuloare(string culoare)
        {
            this.culoare= culoare;
        }

        public string descriereBarca()
        {
            string text = "";

            text+=this.cuMotor+", ";
            text+=this.caiPutere+", ";
            text+=this.culoare;

            return text;
        }

    }
}
