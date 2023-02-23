

using Teorie.cladire;


//Muzeu b = new Muzeu("ceva",100,1998, "muzeu", 2, 3);

//Spital a = new Spital(20, 50, "spital", 4, 5);

//Console.WriteLine(b.descriere());

//Console.WriteLine(a.descriere());

using Teorie;

Barca a = new Barca(true, 200, "alb", "ceva", 2010, true);
Barca b = new Barca(false, 350, "rosu", "bmw", 2021, false);
Barca c = new Barca(true, 100, "negru", "ford", 2024, false);

Masina d = new Masina("audi", 2009, true, 4, 400, "benzina");
Masina e = new Masina("dacia", 2029, true, 4, 1000, "");



List<Vehicul> vehicule= new List<Vehicul>();


vehicule.Add(a);
vehicule.Add(b);
vehicule.Add(c);
vehicule.Add(d);
vehicule.Add(e);
for(int i = 0; i<vehicule.Count; i++)
{

     if(vehicule[i] is Barca)
    {

        Barca t = vehicule[i] as Barca;//conversia de la baza la derivata


        Console.WriteLine(t.descriereBarca());
    }

     if(vehicule[i] is Masina)
    {

        Masina m = vehicule[i] as Masina;

        Console.WriteLine(m.descriereMasina());

    }



}

















