using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice.Models;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private IPracticeRepository repository;

        public int PageSize = 2;                  // Quy định có bn sp trên 1 page

        public HomeController(IPracticeRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(int productPage = 1)
        => View(repository.Employees
            .OrderBy(p => p.EmployeeID)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize)
            );


    }
}
