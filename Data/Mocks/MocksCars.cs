using ASP.Data.Interfaces;
using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data.Mocks
{
    public class MocksCars : IAllCars
    {
        private readonly ICarsCategory _categorycars = new MockCategory();
        public IEnumerable<Car> cars {
            get
            {
                return new List<Car> {
                    new Car{Name="Tesla",Shortdesc ="",LongDesc="",Img="https://img.rg.ru/img/content/168/29/51/34_d_850.jpg",Price=10000,IsFavourite=true,IsAvailible=true,Category=_categorycars.GetAllCategories.First() },
                    new Car {Name="Lada",Shortdesc ="",LongDesc="",Img="https://st2.zr.ru/_ah/img/XA6hSCScVZIy3rg4VmJRKw=s800",Price=3000,IsFavourite=true,IsAvailible=true,Category=_categorycars.GetAllCategories.Last()}
                };
            }
            }
        public IEnumerable<Car> GetFavCars { get; set; } 

        public Car GetObjectCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
