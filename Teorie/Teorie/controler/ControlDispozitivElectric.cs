using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie.dispozitiv_electric;

namespace Teorie.controler
{
    public class ControlDispozitivElectric
    {

        public List<DispozitivElectric> lista = new List<DispozitivElectric>();

        public ControlDispozitivElectric()
        {
            this.load();
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Data\charp\Mostenirea\Teorie\Teorie\bin\Debug\net6.0\data3\dispozitive.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {

                switch (line.Split(",")[0])
                {

                    case "dispozitivElectric":

                        this.lista.Add(new DispozitivElectric(line));
                        break;
                    case "dispozitivElectronic":
                        this.lista.Add(new DispozitivElectronic(line));
                        break;
                    case "dispozitivElectrocasnic":
                        this.lista.Add(new DispozitivElectrocasnic(line));
                        break;
                    case "frigider":
                        this.lista.Add(new Frigider(line));
                        break;
                    case "televizor":
                        this.lista.Add(new Televizor(line));
                        break;

                }
            }

        }

        public void afisare()
        {


            for (int i = 0; i<lista.Count; i++)
            {

                if (lista[i] is Televizor)
                {
                    Televizor t = lista[i] as Televizor;
                    Console.WriteLine(t.televizorDescriere());
                }

                else if (lista[i] is Frigider)
                {
                    Frigider f = lista[i] as Frigider;
                    Console.WriteLine(f.frigiderDescriere());
                }

                else if (lista[i] is DispozitivElectrocasnic)
                {
                    DispozitivElectrocasnic electrocasnic = lista[i] as DispozitivElectrocasnic;
                    Console.WriteLine(electrocasnic.disElectrocasnicDescriere());
                }

                else if (lista[i] is DispozitivElectronic)
                {
                    DispozitivElectronic electronic = lista[i] as DispozitivElectronic;
                    Console.WriteLine(electronic.disElectronicDescriere());
                }

                else if (lista[i] is DispozitivElectric)
                {
                    DispozitivElectric electric = lista[i] as DispozitivElectric;
                    Console.WriteLine(electric.disElectricDescriere());
                }


            }
        }


    }
}
