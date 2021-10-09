using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_Programowanie_projekt_1.Models;

namespace WSEI_Programowanie_projekt_1.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductModel product)
        {
            var viewModel = new ProductStatsViewModel
            {
                NameLength = product.Name.Length,
                DescriptionLength = product.Description.Length,
            };
            return View(viewModel);
        }
    }
}
