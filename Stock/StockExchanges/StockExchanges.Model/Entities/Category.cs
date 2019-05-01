using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockExchanges.Model
{
    [Table("Category")]
    public class Category : AuditableEntity<int>
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
