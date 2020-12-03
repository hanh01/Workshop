using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class EFPracticeRespository : IPracticeRepository
    {
        private EmployeeDbContext context;
        public EFPracticeRespository(EmployeeDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Employee> Employees => context.Employees;
    }
}
