using ASP.Data.Interfaces;
using ASP.Models;
using ASP.Repository;
using ASP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Controllers
{
    public class ShopCartController: Controller //контроллер для работы корзины
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        {
            //var items = _shopCart.GetShopCartItems();
            // _shopCart.ListShopItems =items;
            _shopCart.ListShopItems = _shopCart.GetShopCartItems();//заполнение массива из БД

            ShopCartViewModel obj = new ShopCartViewModel()
            {
                ShopCart = _shopCart//передача корзины с заполненным массивом в корзину модели представления
            };
            return View(obj);
        }
        public RedirectToActionResult addToCart(int id) //функция переадресовывает на другую страницу 
        {
            var item = _carRep.cars.FirstOrDefault(i=>i.Id==id);
            if(item!=null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
