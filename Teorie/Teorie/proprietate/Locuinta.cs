using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.proprietate
{
    public class Locuinta:Proprietate
    {
        private int floors;
        private int price;
        private string address;

        public Locuinta()
        {

        }

        public Locuinta(int floors,int price, string address,string ownerName,int purchaseYear):base("locuinta",ownerName,purchaseYear)
        {
            this.floors = floors;
            this.price = price;
            this.address = address;
        }

        public Locuinta(string prop)
        {
            string[] a = prop.Split(",");

            this.floors =int.Parse(a[3]);
            this.price=int.Parse(a[4]);
            this.address=a[5];

        }

        public int Floors
        {
            get { return this.floors; }
            set { this.floors = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { this.price = value;}
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string locuintaDescription()
        {

            string text = base.proprietateDescription();

            text+="number of floors: "+this.floors+", ";
            text+="price: "+this.price+", ";
            text+="address: "+this.address+", ";

            return text;

        }



    }
}
