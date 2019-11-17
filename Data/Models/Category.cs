using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data.Models
{
    public class Category
{
    public int id { get; set; }
    public string CategoryName { get; set; } 
    public string desc { get; set; } //описание категории
    public List<Car> Cars { get; set; } //cписок всех товаров, входящих в категорию  
}
}
