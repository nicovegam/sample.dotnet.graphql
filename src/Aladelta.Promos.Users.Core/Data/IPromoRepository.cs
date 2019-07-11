using Aladelta.Promos.Users.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aladelta.Promos.Users.Core.Data
{
    public interface IPromoRepository
    {
        Task<Promo> Get(Guid Id);
        Task<Promo> GetRandom();
        Task<List<Promo>> All();
    }
}
