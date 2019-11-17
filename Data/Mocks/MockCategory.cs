using ASP.Data.Interfaces;
using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data.Mocks //В Mocks мы реализуем созданные интерфейсы для заполнения объектами 
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> GetAllCategories {
            get
            {
                return new List<Category> {
                    new Category {CategoryName="Электромобили",desc="Невредный вид транспорта" },
                    new Category{ CategoryName="Классические",desc="Автомобили с двигателем внутреннего сгорания" } 
                };
            }
        }
        }
}
