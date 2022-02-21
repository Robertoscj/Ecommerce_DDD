using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ContextBase :DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
           
        }

        public DbSet<Produto> produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnectionString());
                base.OnConfiguring(optionsBuilder);
            }

           
        }

        private string GetStringConnectionString()
        {
            string strCon = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword";
            return strCon;
        }
    }
}
