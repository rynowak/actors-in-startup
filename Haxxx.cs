using System;
using System.Collections.ObjectModel;
using System.Text.Json;
using Dapr.Actors.Runtime;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DaprServiceCollectionBuilder
    {
        public static DaprBuilder AddDapr(this IServiceCollection services, Action<DaprClientOptions> configure = null)
        {
            // add dapr client

            return new DaprBuilder();
        }
    }

    public sealed class DaprBuilder
    {
        IServiceCollection Services { get; }

        public DaprBuilder AddActors(Action<ActorRuntimeOptions> configure)
        {
            return this;
        }
    }

    public class DaprClientOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; set; }
    }

    public class ActorRuntimeOptions
    {
        public ActorRegistrationCollection Actors { get; }
    }

    public class ActorRegistration
    {
    }

    public class ActorRegistrationCollection : KeyedCollection<ActorTypeInformation, ActorRegistration>
    {
        public void RegisterActor<TActor>()
        {
        }

        protected override ActorTypeInformation GetKeyForItem(ActorRegistration item)
        {
            throw new NotImplementedException();
        }
    }
}

namespace Microsoft.AspNetCore.Builder
{
    public static class DaprActorsEndpointRouteBuilderExtensions
    {
        public static IEndpointConventionBuilder MapActorsHandler(this IEndpointRouteBuilder routes)
        {
            throw null;
        }
    }
}