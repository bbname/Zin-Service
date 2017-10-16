using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Zin_Service.BusinessLogic.AutofacConfiguration;
using Zin_Service.Service.AutofacConfiguration;
using Zin_Service.WebUI;

namespace Zin_Service.Infrastructure
{
    public static class AutofacConfiguration
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterAssemblyModules(typeof(MvcApplication));
            builder.RegisterModule(new BusinessLogicModule());
            builder.RegisterModule(new ServiceModule());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}