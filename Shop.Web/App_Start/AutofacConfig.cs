using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using BusinessLogic.IServices;
using BusinessLogic.Services;
using DAL;
using DAL.Entities;
using DAL.Repository;

namespace Shop.Web
{
    public static class AutofacConfig
    {

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            RegisterDataAccess(builder);
            RegisterServices(builder);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        public static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeTypeService>().As<IEmployeeTypeService>();
        }

        public static void RegisterDataAccess(ContainerBuilder builder)
        {
            builder.RegisterType<Repository<EmployeeType>>().As<IRepository<EmployeeType>>();
            builder.RegisterType<ShopContext>().InstancePerRequest();
        }

    }
}