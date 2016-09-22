using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using NBetting.Web.Infrastructure.Commands;
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
        }

        public static void RegisterExecutors(ContainerBuilder builder)
        {
            builder.RegisterType<CommandExecutor>().As<ICommandExecutor>();
            builder.RegisterType<QueryExecutor>().As<IQueryExecutor>();

            var assembly = Assembly.GetAssembly(typeof(AssemblyMarker));

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(ICommandHandler<>)).InstancePerDependency();

            builder.RegisterAssemblyTypes(assembly)
                .AsClosedTypesOf(typeof(IQueryHandler<,>)).InstancePerDependency();
        }
    }
}
