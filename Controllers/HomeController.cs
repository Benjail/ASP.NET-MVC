using ASP.Data.Interfaces;
using ASP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;
        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homecars = new HomeViewModel { Favcars = _carRep.GetFavCars };
            return View(homecars);
        }
    }
}
