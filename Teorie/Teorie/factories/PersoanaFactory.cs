using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie.persoana;

namespace Teorie.factories
{
    public class PersoanaFactory : IPersoanaFactory
    {
        public Persoana createPersoana(string propritetati)
        {
            switch (propritetati.Split(",")[0])
            {
                case "administrator": return new Administrator(propritetati);
                case "staff": return new Staff(propritetati);
                case "faculty": return new Faculty(propritetati);
                case "employee": return new Employee(propritetati);
                case "student":return new Student(propritetati);
            }

            return null;
        }

    }
}
