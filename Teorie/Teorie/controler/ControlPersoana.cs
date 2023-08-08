using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie.persoana;

using Teorie.factories;
namespace Teorie.controler
{
    public class ControlPersoana
    {

        public List<Persoana> lista=new List<Persoana>();


        private IPersoanaFactory persoanaFactory;
        
        public ControlPersoana()
        {
            this.persoanaFactory = new PersoanaFactory();
            this.load();

        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Data\charp\Mostenirea\Mostenirea\Teorie\Teorie\bin\Debug\net6.0\data\in.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                this.lista.Add(this.persoanaFactory.createPersoana(line));
            }
        }

        public void afisare()
        {
          
            for(int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i].description());
            }
        }

        public string toString()
        {
            string text = "";
            for (int i = 0; i<lista.Count; i++)
            {
               text+=lista[i].description()+"\n";
            }
            return text;
        }

        public int sizeOfObject(string type)
        {
            int ct = 0;

            for(int i = 0; i<lista.Count; i++)
            {
                if (lista[i].Type.Equals(type))
                {
                    ct++;
                }
            }
            return ct;
        }


    }
}
