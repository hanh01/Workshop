using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Employee
    {
        public long EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }
    }
}
