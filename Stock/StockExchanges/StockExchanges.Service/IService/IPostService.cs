using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Service
{
    public interface IcommentService : IEntityService<Post>
    {
        Post GetById(long Id);
    }
}
