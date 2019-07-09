using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aladelta.Promos.User.Models
{
    public class PromoUserSchema : Schema
    {
        public PromoUserSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PromoUserQuery>();
            //Mutation = resolver.Resolve<NHLStatsMutation>();
        }
    }
}
