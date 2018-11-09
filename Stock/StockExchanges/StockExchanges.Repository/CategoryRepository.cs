using Microsoft.EntityFrameworkCore;
using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockExchanges.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context)
              : base(context)
        {

        }
        public Category GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}
