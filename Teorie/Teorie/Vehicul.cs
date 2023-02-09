using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie
{
    public  class Vehicul
    {
        private  string brand;
        private  int year;
        private  bool sport;

        public Vehicul()
        {
            Console.WriteLine("eu sunt constructorul cu 0 parametri din vehicul");
        }

        public Vehicul(string brand,int year,bool sport)
        {
            Console.WriteLine("eu sunt constructorul cu 3 parametri din vehicul");
            this.brand = brand;
            this.year = year;
            this.sport = sport;
        }

        public Vehicul(string brand,int year)
        {
            Console.WriteLine("eu sunt constructorul cu 2 parametri din vehicul");
            this.brand=brand;
            this.year = year;

        }

        public Vehicul(int year)
        {
            Console.WriteLine("eu sunt constructorul cu 1 parametru din vehicul");
            this.year = year;

        }

        public string getBrand()
        {
            return this.brand;   

        }

        public void setBrand(string brand)
        {

            this.brand=brand;

        }

        public int getYear()
        {
            return this.year;
        }

        public void setYear(int year)
        {
            this.year=year;
        }

        public bool getSport()
        {
            return this.sport;
        }

        public void setSport(bool sport)
        {
            this.sport=sport;
        }

        public string descriereVehicul()
        {

            string text = "";

            text+=this.brand+", ";
            text+=this.year+", ";
            text+=this.sport;

            return text;

        }


    }
}
