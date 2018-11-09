using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Repository
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Post GetById(long id);
    }
}
