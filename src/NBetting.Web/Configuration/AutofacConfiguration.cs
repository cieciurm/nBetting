using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace NBetting.Web.Configuration
{
    public static class AutofacConfiguration
    {
        public static IContainer BuildContainer(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            AutofacRegistrations.Register(builder);
            builder.Populate(services);

            return builder.Build();
        }
    }
}
