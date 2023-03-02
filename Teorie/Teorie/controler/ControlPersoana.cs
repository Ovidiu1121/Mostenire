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

                if (lista[i] is Faculty)
                {
                    Faculty faculty = lista[i] as Faculty;
                    Console.WriteLine(faculty.facultyDescription());
                }

                else if (lista[i] is Administrator)
                {
                     Administrator administrator = lista[i] as Administrator;
                    Console.WriteLine(administrator.administartorDescription());
                }

                else if (lista[i] is Staff)
                {
                    Staff staff = lista[i] as Staff;
                    Console.WriteLine(staff.staffDescription());
                }

               else  if (lista[i] is Employee)
                {
                    Employee employee = lista[i] as Employee;
                    Console.WriteLine(employee.employeeDescription());
                }

                else if (lista[i] is Student)
                {
                    Student student = lista[i] as Student;
                    Console.WriteLine(student.studentDescription());
                }


            }
        }


    }
}
