using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Data;
using ASP.Data.Interfaces;
using ASP.Data.Mocks;
using ASP.Models;
using ASP.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NET_MVC
{
    public class Startup
    {
        private IConfigurationRoot _confstring; //!
        public Startup(IHostingEnvironment hostEnv)   //!
        {
            _confstring = new ConfigurationBuilder() //строитель конфигурации
                .SetBasePath(hostEnv.ContentRootPath)
                .AddJsonFile("dbsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //сервисы объекта:IServiceCollection
            services.AddDbContext<AppDBContent>(options=>options.UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));//!
            services.AddMvc(); //добавил концепцию MVC
            services.AddTransient<IAllCars,CarRepository>();//закрепил реализацию интерфейса IAllCars в MocksCars !
            services.AddTransient<ICarsCategory, CategoryRepository>();//!

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();//??
            services.AddScoped(sp => ShopCart.GetCart(sp));//??
            services.AddMemoryCache();//??
            services.AddSession();//??
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. 
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        { //методы объекта IApplicationBuilder:
            app.UseSession();//??
            app.UseDeveloperExceptionPage(); // то выводим информацию об ошибке, при наличии ошибки
            app.UseStatusCodePages(); //?? 
            app.UseStaticFiles(); //Статические файлы CSS, JS , IMG
            app.UseMvcWithDefaultRoute(); //Дефолтный маршрут URL (HomeControler, Index.html)
            if (env.IsDevelopment())  // если приложение в процессе разработки
            {
                app.Run(async (context) =>
                {
                    await context.Response.WriteAsync("In Development!");
                });
            }
        }   
        }
    }
