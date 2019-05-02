using Microsoft.EntityFrameworkCore;
using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockExchanges.Repository
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(DbContext context)
            : base(context)
        {

        }

        public override IEnumerable<Post> GetAll()
        {
            return _entities.Set<Post>().Include(x => x.Category).AsEnumerable();
        }

        public Post GetById(long id)
        {
            return _dbset.Include(x => x.Category).Include(x=>x.Comments).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
