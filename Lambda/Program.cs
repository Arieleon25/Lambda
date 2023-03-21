using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();

            List<Employee> employees = new List<Employee>();
            List<Employee> sameName = new List<Employee>();
            List<string> fnames = new List<string>()
            {
                "Arie", "Rafael", "Eliel", "Joe", "Ariel", "Asher", "Rigi", "Dana", "Joe", "Diego"
            };

            List<string> lnames = new List<string>()
            {
                " Eskinazi", " Eskinazi", " Eskinazi", " Andrade", " Medina", " Kleiman", " Andrade", " Rei", " Doe", " Sudarsky"
            };

            List<int> ids = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            int i = 0;

            foreach(string fname in fnames)
            {
                employees.Add(new Employee(fnames[i], lnames[i], ids[i]));
                i++;
            }

            int j = 0;

            foreach (Employee employee in employees)
            {
                if (fnames[3] == employee.FirstName)
                {
                    sameName.Add(employee);
                }
            }

            List<Employee> newList = employees.Where(x => x.FirstName == fnames[3]).ToList();

            List<Employee> ListGraterfive = employees.Where(x => x.ID > ids[4]).ToList();

            
            Console.ReadLine();
        }
    }
}

