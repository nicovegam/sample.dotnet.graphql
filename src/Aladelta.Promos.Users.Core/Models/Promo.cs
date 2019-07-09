using System;
using System.Collections.Generic;
using System.Text;

namespace Aladelta.Promos.User.Core.Models
{
    public class Promo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal DiscountPercentage { get; set; }

        public Provider Provider { get; set; }
    }
}
