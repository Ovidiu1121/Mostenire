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

        public Administrator(int vechime,int nrDeSubordonatiint,int id, int salary, string job, string name, int age, string gender, string type) : base(id, salary, job, name, age, gender, type)
        {
            this.vechime = vechime;
            this.nrDeSubordonati = nrDeSubordonati;
           
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

        public override string description()
        {
            string text =base.description();

            text+="vechime: "+this.vechime+", ";
            text+="nr de subordonati: "+this.nrDeSubordonati;

            return text;
        }


    }
}
