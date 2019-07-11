using Aladelta.Promos.Users.Helpers;
using Aladelta.Promos.Users.Models;
using Aladelta.Promos.Users.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aladelta.Promos.Users.Models
{
    public class Queries : ObjectGraphType
    {
        public Queries(ContextServiceLocator contextServiceLocator)
        {
            Field<PromoType>(
                "promo",
                arguments: new QueryArguments(new QueryArgument<IdGraphType> { Name = "id" }),
                resolve: context => contextServiceLocator.PromoRepository.Get(context.GetArgument<Guid>("id")));

            Field<PromoType>(
                "randomPromo",
                resolve: context => contextServiceLocator.PromoRepository.GetRandom());

            Field<ListGraphType<PromoType>>(
                "promos",
                resolve: context => contextServiceLocator.PromoRepository.All());
        }
    }
}
