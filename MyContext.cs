using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEntityFramework
{
    public class MyContext : DbContext
    {
        string ConnectionString = "Server=.; Database=testFeature; user id=sa; password=123; trustservercertificate=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<test> test { get; set; }
    }
}
