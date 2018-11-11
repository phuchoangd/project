using Microsoft.EntityFrameworkCore;
using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockExchanges.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context)
              : base(context)
        {

        }
        public Comment GetById(long id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }
    }
}
