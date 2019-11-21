using ASP.Data.Interfaces;
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
        public ViewResult List()
        {                                                                       
            CarsListViewModels obj = new CarsListViewModels(); //создаю объект модели представления
            obj.getAllCars = _allCars.cars; //заполняю обект М. представления объектами бизнес-модели (экземплярами классов Mocks, реализующих интерфейс)
            ViewBag.Title = "Страница с автомобилями";
            return View(obj);
        }
    }
}
