using System;
using System.Collections.Generic;
using System.Text;

namespace Aladelta.Promos.Users.Core.Models
{
    public abstract class Promo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Conditions { get; set; }
        public Provider Provider { get; set; }
    }
}
