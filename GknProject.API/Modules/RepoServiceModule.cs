using Autofac;
using GknProject.Core.Models;
using GknProject.Core.Repositories;
using GknProject.Core.Service;
using GknProject.Core.UnitOfWorks;
using GknProject.Repository.Repositories;
using GknProject.Repository.UnitOfWorks;
using GknProject.Service.Mapping;
using GknProject.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace GknProject.UI.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();


            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var coreAssembly = Assembly.GetAssembly(typeof(GknKargoErpContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(coreAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();
            
            builder.RegisterAssemblyTypes(coreAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
