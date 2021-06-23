using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarProje.DataAccess.Configurations;
using TekrarProjesi.Entities.Concrete;

namespace TekrarProje.DataAccess.Context
{
    public class ReTodoContext : DbContext
    {
        public ReTodoContext(DbContextOptions<ReTodoContext> options) : base(options)
        {
            
        }        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
        }
        public DbSet<Work> Works { get; set; }
    }
}
