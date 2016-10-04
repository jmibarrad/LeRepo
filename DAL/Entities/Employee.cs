using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeType Type { get; set; }
        public int Telephone { get; set; }
        public string Address { get; set; }
        public DateTime EmploymentDate { get; set; }

    }
}
