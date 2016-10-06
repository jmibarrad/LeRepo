using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class ShopDbInitializer: CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            //context.Employees.Add(new Employee());
            //context.Shops.Add(new Shop());
            context.EmployeeTypes.Add(new EmployeeType {Id = 1,Name = "ET1",Salary = 100});
            context.EmployeeTypes.Add(new EmployeeType {Id = 2,Name = "ET2",Salary = 200});
            context.EmployeeTypes.Add(new EmployeeType {Id = 3,Name = "ET3",Salary = 300});
            base.Seed(context);
        }
    }
}
