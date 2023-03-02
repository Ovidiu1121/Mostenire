using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.proprietate
{
    public class Proprietate
    {
        private string type;
        private string ownerName;
        private int purchaseYear;

        public Proprietate()
        {

        }

        public Proprietate(string type,string ownerName,int purchaseYear)
        {
            this.type = type;
            this.ownerName = ownerName;
            this.purchaseYear = purchaseYear;
        }

        public Proprietate(string prop)
        {

            string[] a = prop.Split(",");

            this.type = a[0];
            this.ownerName = a[1];
            this.purchaseYear = int.Parse(a[2]);

        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string OwnerName
        {
            get { return this.ownerName; }
            set { this.ownerName = value; }
        }

        public int PurchaseYear
        {
            get { return this.purchaseYear; }
            set { this.purchaseYear = value; }
        }

        public string proprietateDescription()
        {

            string text = "";

            text+="type: "+this.type+", ";
            text+="owner name: "+this.ownerName+", ";
            text+="purchase year: "+this.PurchaseYear+", ";

            return text;
        }


    }
}
