using Autofac;
using Zin_Service.BusinessLogic.AutofacConfiguration;
using Zin_Service.Service.AutofacConfiguration;

namespace Zin_Service.Infrastructure.AutofacConfiguration
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IDetermineInfrastructureAssembly).Assembly)
                .AsImplementedInterfaces()
                .InstancePerRequest();
            this.AddModules(builder);
            base.Load(builder);
        }

        private void AddModules(ContainerBuilder builder)
        {
            builder.RegisterModule(new BusinessLogicModule());
            builder.RegisterModule(new ServiceModule());
        }
    }
}