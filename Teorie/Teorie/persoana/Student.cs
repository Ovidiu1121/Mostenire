using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.persoana
{
    public class Student:Persoana
    {
        private int id;
        private int grade;
        private string school;

        public Student()
        {

        }

        public Student(int id,int garde,string school,string name,int age,string gender,string type):base()
        {
            this.id=id;
            this.grade = garde;
            this.school=school;
        }

        public Student(string prop)
        {
            string[] a = prop.Split(",");

            this.id = int.Parse(a[4]);
            this.grade = int.Parse(a[5]);
            this.school = a[6];

        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Grade
        {
            get { return this.grade; }
            set { this.grade=value; }
        }

        public string School
        {
            get { return this.school; }
            set { this.school=value; }
        }

        public string studentDescription()
        {
            string text = base.personDescription();

            text+="id: "+this.id+", ";
            text+="grade: "+this.Grade+", ";
            text+="school: "+this.school;

            return text;
        }


    }
}
