using Microsoft.AspNetCore.Mvc;
using Pustok.DAL;
using Pustok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //list<slider> sliders = _context.sliders.orderby(x => x.order).tolist();

            //HomeViewModel homeVM = new HomeViewModel
            //{
            //    Sliders = sliders,
                
            //};

            return View();
        }
    }
}
