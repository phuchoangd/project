using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockExchanges.Model.Entities
{
    public class Member : Entity<long>
    {
        [MaxLength(56)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(56)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(56)]
        public string LastName { get; set; }

        [MaxLength(256)]
        public string Address { get; set; }
    }
}
