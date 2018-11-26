using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Service
{
    public interface ICommentService : IEntityService<Comment>
    {
        Comment GetById(long Id);
    }
}
