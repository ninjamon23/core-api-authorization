using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Entities
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>().Ignore(e => e.FullName);
        }

        private static string GetConnectionString()
        {
            //const string databaseName = "webapijwt";
            //const string databaseUser = "root";
            //const string databasePass = "1";

            //return $"Server=localhost;" +
            //       $"database={databaseName};" +
            //       $"uid={databaseUser};" +
            //       $"pwd={databasePass};" +
            //       $"pooling=true;";

            // TODO: Change this to the actual database connection
            return @"Data Source=JORDAN-DEV\SQLEXPRESS;Initial Catalog=AppDb;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
