using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Models
{
    public class ShopCartItem
    {
        public int Id {get;set;} // общий ID 
        public Car Car  {get;set;}
        public int Price {get;set;}
        public string ShopCartId {get;set;} //ID товара внутри корзины
    }
}
