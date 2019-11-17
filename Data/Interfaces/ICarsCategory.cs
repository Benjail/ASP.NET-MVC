using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data.Interfaces                                           
{
    interface ICarsCategory
{
    IEnumerable<Category> GetAllCategories { get;}  //функция возвращает список типа Category


}
}
