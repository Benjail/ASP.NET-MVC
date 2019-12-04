using ASP.Data;
using ASP.Data.Models;
using ASP.NETMVC.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string CartId { get; set; } //название корзины 
        public List<ShopCartItem> ListShopItems { get; set; }
        public static ShopCart GetCart(IServiceProvider services) //функция возвращает, добавлял ли пользователь в корзину товар или нет
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; //объект для работы с сессиями
            var context = services.GetService<AppDBContent>();//переменна для работы с БД
            string ShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();//если сессии нет, то создается новый ShopCartId      
            session.SetString("CartId", ShopCartId);
            return new ShopCart(context) { CartId = ShopCartId };//возвращаем корзину
        }
        public void AddToCart(Car car)
        { //функция добавляет новую машину в корзину
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = CartId,
                Car = car,
                Price = car.Price
            }
            );
            appDBContent.SaveChanges(); 
        }
        public List<ShopCartItem> GetShopCartItems() //функция возвращает список товаров корзины 
        {
            return appDBContent.ShopCartItem.Where(c => c.ShopCartId == CartId).Include(s => s.Car).ToList(); //Функция возвращает список машин в корзине
        }//далее устанавливаю пакет Microsoft.AspNetCore.Session и Microsoft.Extensions.Caching.Memory и Microsoft.AspNetCore.Http.Extensions
    }
}
