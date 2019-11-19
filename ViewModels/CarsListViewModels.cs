using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.ViewModels
{
    public class CarsListViewModels //модель для представляения View
{
        public IEnumerable<Car> getAllCars { get; set; }
        public string carCategory { get; set; }
}
}
