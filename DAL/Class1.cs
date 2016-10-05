using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class ShopContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public ShopContext():base("ShopContext")
        {
            Database.SetInitializer(new ShopDbInitializer());

        }
    }
}
