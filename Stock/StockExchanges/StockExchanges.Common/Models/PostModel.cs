using System;
using System.Collections.Generic;
using System.Text;

namespace StockExchanges.Common.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string ThumbnailImage { get; set; }       
    }
}
