using Aladelta.Promos.Users.Core.Data;
using Aladelta.Promos.Users.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aladeta.Promos.Users.Data.Repositories
{
    public class PromoRepository : IPromoRepository
    {
        private readonly List<Promo> _promos = new List<Promo> {
            new DiscountPromo() {
                Id = new Guid("e6b8b314-b714-4d98-9349-6d405ebad28a"),
                Title = "Hamburguesas",
                Conditions = "Lunes a Jueves",  
                Provider = new Provider
                {
                    Id = new Guid("53928b5c-de4c-4abf-97fc-7f2075ba2fed"),
                    Name = "Bar Tolomeo"
                },
                DiscountPercentage = 50,
                Minimum = 200,
                Maximum = 1000
            },
            new DiscountPromo() {
                Id = new Guid("e6b8b314-b714-4d98-9349-6d405ebad28a"),
                Title = "Pizzas",
                Conditions = "Todos los domingos",
                Provider = new Provider
                {
                    Id = new Guid("53928b5c-de4c-4abf-97fc-7f2075ba2fed"),
                    Name = "Bar Tolomeo"
                },
                DiscountPercentage = 50
            },
            new SpecialPrizePromo() {
                Id = new Guid("441b53bb-c30c-4727-9779-16088ce1c7ec"),
                Title = "Pinta Cream Stout + Pinta Honey",
                Conditions = "De 18 a 21 hs.",
                Provider = new Provider
                {
                    Id = new Guid("9c6256ca-6fcc-4cfe-b5a2-a71a449b89b7"),
                    Name = "Bar Ato"
                },
                Prize = 130,
                OriginalPrize = 250
            },
            new SpecialPrizePromo() {
                Id = new Guid("e3c725ca-237a-4147-8b82-88e7b4c13307"),
                Title = "Papas con cheddar",
                Conditions = "Todos los dias",
                Provider = new Provider
                {
                    Id = new Guid("9c6256ca-6fcc-4cfe-b5a2-a71a449b89b7"),
                    Name = "Bar Ato"
                },
                Prize = 120,
                OriginalPrize = 200
            }
        };

        public async Task<Promo> Get(Guid id)
        {
            return await Task.FromResult(_promos.FirstOrDefault(p => p.Id == id));
        }

        public async Task<Promo> GetRandom()
        {
            return await Task.FromResult(_promos.OrderBy(o => Guid.NewGuid()).FirstOrDefault());
        }

        public async Task<List<Promo>> All()
        {
            return await Task.FromResult(_promos);
        }
    }
}
