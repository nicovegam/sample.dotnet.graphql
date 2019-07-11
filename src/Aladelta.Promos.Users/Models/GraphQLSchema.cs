using Aladelta.Promos.Users.Types;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aladelta.Promos.Users.Models
{
    public class GraphQLSchema : Schema
    {
        public GraphQLSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<Queries>();
            RegisterType<DiscountPromoType>();
            RegisterType<SpecialPrizePromoType>();
            //Mutation = resolver.Resolve<NHLStatsMutation>();
        }
    }
}
