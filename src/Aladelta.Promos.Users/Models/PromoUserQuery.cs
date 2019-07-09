using Aladelta.Promos.Users.Helpers;
using Aladelta.Promos.Users.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aladelta.Promos.User.Models
{
    public class PromoUserQuery : ObjectGraphType
    {
        public PromoUserQuery(ContextServiceLocator contextServiceLocator)
        {
            Field<PromoType>(
                "promo",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "id" }),
                resolve: context => contextServiceLocator.PromoRepository.Get(context.GetArgument<Guid>("id")));

            Field<ListGraphType<PromoType>>(
                "promos",
                resolve: context => contextServiceLocator.PromoRepository.All());
        }
    }
}
