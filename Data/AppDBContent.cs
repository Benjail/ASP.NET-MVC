using ASP.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data
{
    public class AppDBContent:DbContext //создаю контекст
{
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }
        public DbSet<Car> car { get; set; } //функция установки-получения объектов Car из DB
        public DbSet<Category> category { get; set; } //функция установки-получения объектов Category из DB

    }
}
