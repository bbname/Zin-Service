using Autofac;

namespace Zin_Service.BusinessLogic.AutofacConfiguration
{
    public class BusinessLogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(IDetermineBusinessLogicAssembly).Assembly)
                .AsImplementedInterfaces()
                .InstancePerRequest();
            base.Load(builder);
        }
    }
}