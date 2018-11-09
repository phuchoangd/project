using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetById(int id);
    }
}
