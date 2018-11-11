using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Repository
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Comment GetById(long id);
    }
}
