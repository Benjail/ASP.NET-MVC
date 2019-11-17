using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data.Interfaces
{
    interface IAllCars
{
    IEnumerable<Car> cars { get;}
    IEnumerable<Car> GetFavCars { get; set; }
    Car GetObjectCar(int id);
    }
}
