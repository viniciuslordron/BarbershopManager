using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace BarbershopLibrary.Data
{
    public class BarbershopContextFactory : IDesignTimeDbContextFactory<BarbershopContext>
    {
        public BarbershopContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BarbershopContext>();

            optionsBuilder.UseSqlServer(@"Server=VINICIUS\SQLEXPRESS;
            DataBase=BarbershopDb;
            integrated security=true;TrustServerCertificate=True;");

            return new BarbershopContext(optionsBuilder.Options);
        }
    }
}
