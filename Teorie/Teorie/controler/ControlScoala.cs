using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie.scoala;

namespace Teorie.controler
{
    public class ControlScoala
    {

        public List<Persoana> lista=new List<Persoana>();

        public ControlScoala()
        {
            this.load();
        }

        public void load()
        {

            StreamReader read = new StreamReader(@"C:\Data\charp\Mostenirea\Teorie\Teorie\bin\Debug\net6.0\data4\persoane.txt");

            string line = "";

           while((line = read.ReadLine()) != null)
            {
                switch(line.Split(",")[0])
                {
                    case "elev":this.lista.Add(new Elev(line));
                        break;
                    case "profesor":this.lista.Add(new Profesor(line));
                        break;
                }
            }


        }

        public void afisare()
        {

            for(int i = 0; i<lista.Count; i++)
            {
                if(lista[i] is Elev)
                {
                    Elev elev = lista[i] as Elev;
                    Console.WriteLine(elev.elevDescription());
                }else if(lista[i] is Profesor)
                {
                    Profesor profesor = lista[i] as Profesor;
                    Console.WriteLine(profesor.profesorDescription());
                }
            }

        }


    }
}
