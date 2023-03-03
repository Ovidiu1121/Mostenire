using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie.proprietate;

namespace Teorie.controler
{
    public class ControlProprietate
    {
        public List<Proprietate> lista = new List<Proprietate>();

        public ControlProprietate()
        {
            this.load();
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Data\charp\Mostenirea\Teorie\Teorie\bin\Debug\net6.0\data2\proprietate.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {

                switch (line.Split(",")[0])
                {

                    case "locuinta":

                        this.lista.Add(new Locuinta(line));
                        break;
                    case "casa":
                        this.lista.Add(new Casa(line));
                        break;
                    case "apartament":
                        this.lista.Add(new Apartament(line));
                        break;
                    case "vehicul":
                        this.lista.Add(new Veh(line));
                        break;
                    case "masina":
                        this.lista.Add(new Car(line));
                        break;

                }
            }

        }

        public void afisare()
        {

            for(int i=0;i<lista.Count;i++)
            {
               

                if(lista[i] is Casa)
                {
                    Casa casa=lista[i] as Casa;
                    Console.WriteLine(casa.casaDescription());
                }

                else if(lista[i] is Apartament)
                {
                    Apartament apartament = lista[i] as Apartament;
                    Console.WriteLine(apartament.aparatamentDescription());
                }
                else if (lista[i] is Locuinta)
                {
                    Locuinta locuinta = lista[i] as Locuinta;
                    Console.WriteLine(locuinta.locuintaDescription());
                }

                else if (lista[i] is Car)
                {
                    Car car = lista[i] as Car;
                    Console.WriteLine(car.masinaDescription());
                }

                else if (lista[i] is Veh)
                {
                    Veh veh = lista[i] as Veh;
                    Console.WriteLine(veh.vehiculDescription());
                }

               
            }

        }


    }
}
