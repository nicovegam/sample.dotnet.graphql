using Aladelta.Promos.Users.Core.Models;
using Aladelta.Promos.Users.Helpers;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aladelta.Promos.Users.Types
{
    public class DiscountPromoType : ObjectGraphType<DiscountPromo>
    {
        public DiscountPromoType(ContextServiceLocator contextServiceLocator)
        {
            Field("id", x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Title);
            Field(x => x.Conditions);
            Field("providerId", x => x.Provider.Id, type: typeof(IdGraphType));
            Field("providerName", x => x.Provider.Name);

            Field(x => x.DiscountPercentage);
            Field(x => x.Minimum, nullable: true);
            Field(x => x.Maximum, nullable: true);

            Interface<PromoType>();
        }
    }
}
