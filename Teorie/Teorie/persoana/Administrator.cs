using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.persoana
{
    public class Administrator:Employee
    {

        private int vechime;
        private int nrDeSubordonati;
        
        public Administrator()
        {

        }

        public Administrator(int vechime,int nrDeSubordonati) : base()
        {
            this.vechime = vechime;
            nrDeSubordonati = nrDeSubordonati;
           
        }

        public Administrator(string prop) : base(prop)
        {
          
            string[] a = prop.Split(",");

            this.vechime=int.Parse(a[7]);
            this.NrDeSubordonati=int.Parse(a[8]);
        }

        public int Vechime
        {
            get { return this.vechime; }
            set { this.vechime = value;}
        }

        public int NrDeSubordonati
        {
            get { return this.nrDeSubordonati; }
            set { this.nrDeSubordonati=value; }
        }

        public string administartorDescription()
        {
            string text =base.employeeDescription();

            text+="vechime: "+this.vechime+", ";
            text+="nr de subordonati: "+this.nrDeSubordonati;

            return text;
        }


    }
}
