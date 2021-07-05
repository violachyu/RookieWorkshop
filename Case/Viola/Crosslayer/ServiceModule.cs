using System.Reflection;
using Autofac;
using RookieWorkshop.Services;

namespace RookieWorkshop.Crosslayer
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InputService>()
                   .As<IInputService>();
        }
    }
}
