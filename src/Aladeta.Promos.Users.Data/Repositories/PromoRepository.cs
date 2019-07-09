using Aladelta.Promos.User.Core.Data;
using Aladelta.Promos.User.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aladeta.Promos.Users.Data.Repositories
{
    public class PromoRepository : IPromoRepository
    {
        private readonly List<Promo> _players = new List<Promo> {
            new Promo() {
                Id = new Guid("e6b8b314-b714-4d98-9349-6d405ebad28a"),
                Title = "Hamburguesa + Pinta",
                DiscountPercentage = 20,
                Provider = new Provider
                {
                    Id = new Guid("53928b5c-de4c-4abf-97fc-7f2075ba2fed"),
                    Name = "Bar Tolomeo"
                }
            },
            new Promo() {
                Id = new Guid("e3bc8540-5c76-4eb4-834d-097db85eca1d"),
                Title = "10 Hamburguesas",
                DiscountPercentage = 50,
                Provider = new Provider
                {
                    Id = new Guid("704d9885-1f92-4be9-ae51-9e4762b9c2f9"),
                    Name = "Bar On"
                }
            },
            new Promo() {
                Id = new Guid("441b53bb-c30c-4727-9779-16088ce1c7ec"),
                Title = "Pinta Cream Stout",
                DiscountPercentage = 50,
                Provider = new Provider
                {
                    Id = new Guid("9c6256ca-6fcc-4cfe-b5a2-a71a449b89b7"),
                    Name = "Bar Ato"
                }
            },
            new Promo() {
                Id = new Guid("e3c725ca-237a-4147-8b82-88e7b4c13307"),
                Title = "Papas con cheddar",
                DiscountPercentage = 25,
                Provider = new Provider
                {
                    Id = new Guid("9c6256ca-6fcc-4cfe-b5a2-a71a449b89b7"),
                    Name = "Bar Ato"
                }
            }
        };

        public Task<Promo> Get(Guid id)
        {
            return Task.FromResult(_players.FirstOrDefault(p => p.Id == id));
        }

        public Task<Promo> GetRandom()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Promo>> All()
        {
            return Task.FromResult(_players);
        }
    }
}
