using StockExchanges.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockExchanges.Web.ViewModels
{
    public class PostDetailViewModel : PostViewModel
    {
        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}
