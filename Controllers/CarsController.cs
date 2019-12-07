using ASP.Data.Interfaces;
using ASP.Data.Models;
using ASP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Controllers
{
    public class CarsController:Controller
{
        private readonly IAllCars _allCars; 
        private readonly ICarsCategory _allCategories;
        public  CarsController(IAllCars iAllCars, ICarsCategory iAllCategories)
        {
            _allCars = iAllCars; //мы передаем не только интерфейс, но и классы, реализующие его (Mock...) c заполненными данными благодаря "services.AddTransient<ICarsCategory, MockCategory>();"
            _allCategories = iAllCategories;
        }

       [Route("Cars/List")]
       [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars=null;
            string currCategory=null;
            if (string.IsNullOrEmpty(category))
            {
                cars=_allCars.cars.OrderBy(i=>i.Id);
            } else {
                    if(string.Equals("electro",category, StringComparison.OrdinalIgnoreCase))
                    {
                        cars = _allCars.cars.Where(c => c.CategoryId.Equals(1)).OrderBy(i => i.Id);
                        currCategory = "Электромобили";
                    } else if(string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                        {
                        cars = _allCars.cars.Where(c => c.CategoryId.Equals(2)).OrderBy(i => i.Id);
                        currCategory = "Классические";
                        }
            }
            var carobj = new CarsListViewModels { getAllCars = cars, carCategory = currCategory };    
            return View(carobj);
        }
    }
}
