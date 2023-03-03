﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie.persoana
{
    public class Staff:Employee
    {
        private string task;
        private bool dogOwner;
        
        public Staff()
        {

        }

        public Staff(string task,bool dogOwner) : base() 
        {
            this.task = task;
            this.dogOwner = dogOwner;
        }

        public Staff(string prop)
        {

            string[] a = prop.Split(",");

            this.task=a[7];
            this.dogOwner = bool.Parse(a[8]);

        }

        public string Task
        {
            get { return this.task; }
            set { this.task = value; }
        }

        public bool DogOwner
        {
            get { return this.dogOwner; }
            set { this.dogOwner = value; }
        }

        public string staffDescription()
        {
            string text = base.employeeDescription();

            text+="task: "+this.task+", ";
            text+="dog owner: "+this.dogOwner;

            return text;

        }

    }
}
