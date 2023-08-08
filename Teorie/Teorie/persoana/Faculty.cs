using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.persoana
{
    public class Faculty:Employee
    {
        private string descriere;
        private string address;
        private string website;

        public Faculty()
        {

        }

        public Faculty(string descriere, string address,string website,int id, int salary, string job, string name, int age, string gender, string type) : base(id, salary, job, name, age, gender, type)
        {
            this.descriere = descriere;
            this.address = address;
            this.website = website;
        }

        public Faculty(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.descriere=a[7] ;
            this.address=a[8];
            this.website=a[9];

        }

        public string Descriere
        {
            get { return this.descriere; }
            set { this.descriere = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string Website
        {
            get { return this.website; }
            set { this.website=value; }
        }

        public override string description()
        {
            string text = base.description();

            text+="desciption: "+this.descriere+", ";
            text+="Adress: "+this.address+", ";
            text+="website: "+this.website;

            return text;
        }


    }
}
