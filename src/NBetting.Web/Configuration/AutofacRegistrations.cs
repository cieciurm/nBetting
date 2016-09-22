using System.Reflection;
using Autofac;
using NBetting.EFMapping.Context;
using NBetting.Web.Infrastructure.Commands;
using NBetting.Web.Infrastructure.Events;
using NBetting.Web.Infrastructure.Queries;

namespace NBetting.Web.Configuration
{
    public static class AutofacRegistrations
    {
        public static void Register(ContainerBuilder builder)
        {
            RegisterExecutors(builder);
            RegisterServices(builder);
        }

        public static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<BettingContext>().As<IBettingContext>().InstancePerLifetimeScope();
        }

        public static void RegisterExecutors(ContainerBuilder builder)
        {
            builder.RegisterType<CommandExecutor>().As<ICommandExecutor>();
            builder.RegisterType<QueryExecutor>().As<IQueryExecutor>();
            builder.RegisterType<EventPublisher>().As<IEventPublisher>();

            var assembly = Assembly.GetAssembly(typeof(AssemblyMarker));

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>));

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IQueryHandler<,>));

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IEventHandler<>));
        }
    }
}
