using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data.Interfaces
{
    public interface IAllCars
{
    IEnumerable<Car> cars { get;}
    IEnumerable<Car> GetFavCars { get; }
    Car GetObjectCar(int id);
    }
}
