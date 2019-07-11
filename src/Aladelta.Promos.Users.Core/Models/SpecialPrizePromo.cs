using System;
using System.Collections.Generic;
using System.Text;

namespace Aladelta.Promos.Users.Core.Models
{
    public class SpecialPrizePromo : Promo
    {
        public decimal Prize { get; set; }
        public decimal OriginalPrize { get; set; }
    }
}
