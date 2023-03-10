using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.scoala
{
    internal class Profesor : Persoana
    {

        private string materie;
        private int vechime;

        public Profesor()
        {

        }

        public Profesor(string materie, int vechime) : base()
        {
            this.materie = materie;
            this.vechime = vechime;
        }

        public Profesor(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.materie = a[3];
            this.vechime=int.Parse(a[4]);

        }

        public string Materie
        {
            get { return this.materie; }
            set { this.materie=value; }
        }

        public int Vechime
        {
            get { return this.vechime; }
            set { this.vechime=value; }
        }

        public string profesorDescription()
        {
            string text = base.persoanaDescription();

            text+="materie: "+this.materie+",";
            text+="vechime: "+this.vechime+" ani";

            return text;

        }


    }
}
