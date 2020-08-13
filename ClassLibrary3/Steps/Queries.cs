using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection;

namespace ClassLibrary3.Steps
{
    public class Queries
    {
        public string query1;
        public string query2;
        public string query3;

        public Queries()
        {
            query1 = "db.Employee.find({ name: '${EmpName}' })";
            query2 = "select * from employee";
            query3 = "select * from sal";
        }
    }
}
