using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Service
{
    public interface ICategoryService : IEntityService<Category>
    {
        Category GetById(int Id);
    }
}
