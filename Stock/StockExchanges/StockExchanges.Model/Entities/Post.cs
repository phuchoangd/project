using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockExchanges.Model
{
    [Table("Post")]
    public class Post : AuditableEntity<int>
    {
        [MaxLength(256)]
        public string Slug { get; set; }

        [MaxLength(512)]
        public string ShortDescription { get; set; }

        [Required]
        [MaxLength(2048)]
        public string Content { get; set; }

        public string ThumbnailImage { get; set; }

        [Display(Name = "Category")]
        public long CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        //public virtual IEnumerable<Comment> Comments { get; set; }
    }
}
