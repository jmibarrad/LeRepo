using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using BusinessLogic.IServices;
using BusinessLogic.Services;
using DAL;
using DAL.Entities;
using DAL.Repository;

namespace ShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeTypeService>().As<IEmployeeTypeService>();
            builder.RegisterType<ShopContext>().As<ShopContext>();
            builder.RegisterType<Repository<EmployeeType>>().As<IRepository<EmployeeType>>();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IEmployeeTypeService>();
                var list = writer.ListEmployeeTypes();
                foreach (var l in list)
                {
                    Console.WriteLine(l.Name, l.Id, l.Salary);
                }
            }


        }
    }
}
