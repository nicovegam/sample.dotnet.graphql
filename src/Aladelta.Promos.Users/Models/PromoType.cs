using Aladelta.Promos.User.Core.Models;
using Aladelta.Promos.Users.Helpers;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aladelta.Promos.Users.Models
{
    public class PromoType : ObjectGraphType<Promo>
    {
        public PromoType(ContextServiceLocator contextServiceLocator)
        {
            Field("id", x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Title);
            Field(x => x.DiscountPercentage, nullable: true);
            Field("providerId", x => x.Provider.Id, type: typeof(IdGraphType));
            Field(x => x.Provider.Name);
        }
    }
}
