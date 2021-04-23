using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data
{
    public class SocialSecurityDbContext : DbContext
    {
        public SocialSecurityDbContext(DbContextOptions<SocialSecurityDbContext> options)
        : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        
        }


    }
}
