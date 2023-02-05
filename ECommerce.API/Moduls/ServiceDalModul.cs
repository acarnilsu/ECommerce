using Autofac;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using System.Reflection;
using Module = Autofac.Module;

namespace ECommerce.API.Moduls
{
    public class ServiceDalModul:Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var webAssembly = Assembly.GetExecutingAssembly();
            var dalAssembly = Assembly.GetAssembly(typeof(Context));
            var serviceAssembly = Assembly.GetAssembly(typeof(GenericService<>));

            builder.RegisterAssemblyTypes(webAssembly, dalAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Dal")).AsImplementedInterfaces().InstancePerLifetimeScope();


            builder.RegisterAssemblyTypes(webAssembly, dalAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}
