using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.persoana
{
    public class Employee:Persoana
    {
        private int id;
        private int salary;
        private string job;

        public Employee()
        {

        }

        public Employee(int id,int salary,string job,string name,int age,string gender,string type) : base(name, age, gender, "employee")
        {
            this.id = id;
            this.salary = salary;
            this.job = job;
        }

        public Employee(string prop):base(prop) 
        {
            string[] a = prop.Split(",");

            this.id=int.Parse(a[4]);
            this.salary = int.Parse(a[5]);
            this.job = a[6];
          
        }

        public int Id
        {
            get { return this.id; }
            set { id = value; }
        }

        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Job
        {
            get { return this.job; }
            set { this.job=value; }
        }

        public override string description()
        {
            string text = base.description();

            text+="id: "+this.id+", ";
            text+="salary: "+this.salary+", ";
            text+="job: "+this.job+", ";

            return text;

        }

    }
}
