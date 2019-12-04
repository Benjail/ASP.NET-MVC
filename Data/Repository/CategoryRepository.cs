using ASP.Data;
using ASP.Data.Interfaces;
using ASP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent= appDBContent;
        }
        public IEnumerable<Category> GetAllCategories=>appDBContent.category ;
    }
}
