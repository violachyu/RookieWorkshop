using System.Reflection;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RookieWorkshop.Controllers;
using RookieWorkshop.DataAccess;
using RookieWorkshop.Repositories;
using RookieWorkshop.Services;

namespace RookieWorkshop.Crosslayer
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InputService>()
                   .As<IInputService>();
            builder.RegisterType<CacheService>()
                   .As<ICacheService>();
            builder.RegisterType<DataService>()
                   .As<IDataService>();
            builder.RegisterType<DataRepository>()
                   .As<IDataRepository>();
            builder.RegisterType<DataContext>()
                   .As<DataContext>();
        }
    }
}
