using Aladelta.Promos.Users.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aladeta.Promos.Users.Data
{
    public class PromoUserContext : DbContext
    {
        public PromoUserContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Promo> Promos { get; set; }
    }
}
