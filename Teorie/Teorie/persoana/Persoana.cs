using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.persoana
{
    public class Persoana
    {
        private string type;
        private string name;
        private int age;
        private string gender;
      

        public Persoana()
        {

        }

        public Persoana(string name,int age,string gender,string type)
        {
            this.type = type;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Persoana(string proprietatile) 
        { 
       
            String[] cuvinte=proprietatile.Split(",");

           this.type=cuvinte[0];
           this.name=cuvinte[1];
           this.age=int.Parse(cuvinte[2]);
           this.gender=cuvinte[3];

        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public virtual string description()
        {
            string text = "";

            text+="type: "+this.type+", ";
            text+="name: "+this.name+", ";
            text+="age: "+this.age+", ";
            text+="gender: "+this.gender+", ";
            

            return text;

        }






    }
}
