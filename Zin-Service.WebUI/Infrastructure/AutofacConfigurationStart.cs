using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Zin_Service.Infrastructure.AutofacConfiguration;

namespace Zin_Service.WebUI.Infrastructure
{
    public class AutofacConfigurationStart
    {
        public void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterAssemblyModules(typeof(MvcApplication));
            builder.RegisterModule(new InfrastructureModule());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}