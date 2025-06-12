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
        string ConnectionString = Properties.Settings.Default.SqlConnection;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Test> test { get; set; }
    }
}
