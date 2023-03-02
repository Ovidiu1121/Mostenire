using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.persoana
{
    public class Faculty:Employee
    {
        private string description;
        private string address;
        private string website;

        public Faculty()
        {

        }

        public Faculty(string description, string address,string website ) :base()
        {
            this.description = description;
            this.address = address;
            this.website = website;
        }

        public Faculty(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.description=a[7] ;
            this.address=a[8];
            this.website=a[9];

        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
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

        public string facultyDescription()
        {
            string text = base.employeeDescription();

            text+="desciption: "+this.description+", ";
            text+="Adress: "+this.address+", ";
            text+="website: "+this.website;

            return text;
        }


    }
}
