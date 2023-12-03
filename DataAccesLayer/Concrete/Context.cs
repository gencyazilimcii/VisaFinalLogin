using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int> 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2FA3KGC;initial catalog=ViseFinalLogin; integrated Security = true");
        }
        
        public DbSet<CustomerAccount> CustomerAccounts { get; set; } //<CustomerAccount> C# Da ki sınıf ismi diğeri Sql tarafında ki ismi 


        public DbSet<CustomerAccountProcess> CustomerAccountsProcesses { get; set; }

         


    }
}
