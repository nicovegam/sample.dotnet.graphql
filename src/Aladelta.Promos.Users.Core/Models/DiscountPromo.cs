using System;
using System.Collections.Generic;
using System.Text;

namespace Aladelta.Promos.Users.Core.Models
{
    public class DiscountPromo : Promo
    {
        public decimal DiscountPercentage { get; set; }
        public decimal? Minimum { get; set; }
        public decimal? Maximum { get; set; }
    }
}
