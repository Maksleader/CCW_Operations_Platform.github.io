using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using CareProviderPortal.Queries.Container;
using System;

namespace CareProviderPortal.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}