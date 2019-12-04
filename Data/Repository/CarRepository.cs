using ASP.Data;
using ASP.Data.Interfaces;
using ASP.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Repository
{
    public class CarRepository : IAllCars
{
    private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDBContent)                         
        {
            this.appDBContent= appDBContent;                                        
        }
    public IEnumerable<Car> cars => appDBContent.car.Include(C=>C.Category);//методы расширения LINQ.При таком запросе отобразятся все элементы
    public IEnumerable<Car> GetFavCars => appDBContent.car.Where(p => p.IsFavourite).Include(c=>c.Category);
    public Car GetObjectCar(int carId) => appDBContent.car.FirstOrDefault(p => p.Id == carId);
}
}
