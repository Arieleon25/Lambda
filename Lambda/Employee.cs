using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public Employee(string fname, string lname, int id)
        {
            FirstName = fname;
            LastName = lname;
            ID = id;
        }

    }
}


