using Aladelta.Promos.User.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aladelta.Promos.User.Core.Data
{
    public interface IPromoRepository
    {
        Task<Promo> Get(Guid Id);
        Task<List<Promo>> All();
    }
}
