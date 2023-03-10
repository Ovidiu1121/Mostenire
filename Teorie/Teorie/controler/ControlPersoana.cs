using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie.persoana;

namespace Teorie.controler
{
    public class ControlPersoana
    {

        public List<Persoana> lista=new List<Persoana>();
        
        public ControlPersoana()
        {
            this.load();
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Data\charp\Mostenirea\Teorie\Teorie\bin\Debug\net6.0\data\in.txt");

            string line = "";

            while((line = read.ReadLine()) != null)
            {

                switch (line.Split(",")[0])
                {

                    case "administrator":

                        this.lista.Add(new Administrator(line));
                        break;
                    case "employee":
                        this.lista.Add(new Employee(line));
                        break;
                    case "student":
                        this.lista.Add(new Student(line));
                        break;
                    case "faculty":
                        this.lista.Add(new Faculty(line));
                        break;
                    case "staff":
                        this.lista.Add(new Staff(line));
                        break;

                }
            }

        }

        public void afisare()
        {
          
            for(int i = 0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i].description());
            }
        }


    }
}
