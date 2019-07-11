using Aladelta.Promos.Users.Core.Models;
using Aladelta.Promos.Users.Helpers;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aladelta.Promos.Users.Types
{
    public class PromoType : InterfaceGraphType<Promo>
    {
        public PromoType(ContextServiceLocator contextServiceLocator, DiscountPromoType discountPromoType, SpecialPrizePromoType specialPrizePromoType)
        {
            Field("id", x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Title);
            Field(x => x.Conditions);
            Field("providerId", x => x.Provider.Id, type: typeof(IdGraphType));
            Field("providerName", x => x.Provider.Name);
        }
    }
}
