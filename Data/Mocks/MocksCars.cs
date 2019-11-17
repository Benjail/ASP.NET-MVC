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
                    new Car{Name="Tesla",Shortdesc ="",LongDesc="",Img="",Price=10000,IsFavourite=true,IsAvailible=true,Category=_categorycars.GetAllCategories.First() },
                    new Car {Name="Lada",Shortdesc ="",LongDesc="",Img="",Price=3000,IsFavourite=true,IsAvailible=true,Category=_categorycars.GetAllCategories.Last()}
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
