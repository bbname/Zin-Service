using Autofac;

namespace Zin_Service.Service.AutofacConfiguration
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IDetermineServiceAssembly).Assembly)
                .AsImplementedInterfaces()
                .InstancePerRequest();
            base.Load(builder);
        }
    }
}