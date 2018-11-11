using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockExchanges.Model
{
    [Table("Comment")]
    public class Comment : AuditableEntity<long>
    {
        [MaxLength(256)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }

        [Display(Name = "Post")]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }
    }
}
