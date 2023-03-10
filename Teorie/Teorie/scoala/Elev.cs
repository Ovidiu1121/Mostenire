using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.scoala
{
    internal class Elev:Persoana
    {
        private int id;
        private int orePeSaptamana;
        
        public Elev()
        {

        }

        public Elev(int id,int orePeSaptamana) : base()
        {
            this.id = id;
            this.orePeSaptamana = orePeSaptamana;
        }

        public Elev(string prop) : base(prop)
        {
            string[] a = prop.Split(",");

            this.id=int.Parse(a[3]);
            this.orePeSaptamana=int.Parse(a[4]);

        }

        public int Id
        {
            get { return this.id; }
            set { this.id=value; }
        }

        public int OrePeSaptamana
        {
            get { return this.orePeSaptamana; }
            set { this.orePeSaptamana=value; }
        }

        public string elevDescription()
        {
            string text = base.persoanaDescription();

            text+="id: "+this.id+",";
            text+="ore pe saptamana: "+this.orePeSaptamana;

            return text;
        }

        public  override string description()
        {
            string text ="Elev"+ base.persoanaDescription();

            text+="id: "+this.id+",";
            text+="ore pe saptamana: "+this.orePeSaptamana;

            return text;
        }

    }
}
