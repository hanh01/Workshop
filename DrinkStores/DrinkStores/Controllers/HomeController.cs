using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DrinkStores.Models;
using DrinkStores.Models.ViewModels;

namespace DrinkStores.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 2;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }


        public ViewResult Index(string status,int productPage = 1)
            => View(new ProductListViewModel
            {
                Products = repository.Products
                .Where(p => status == null || p.Status == status)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}
