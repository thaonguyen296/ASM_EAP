using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EAP_ASM_NTT.Models
{
    public class MyDbContext : IdentityDbContext<Account>
    {
        public MyDbContext() : base("name=MyDbContext")
        {
        }

        public static MyDbContext Create()
        {
            return new MyDbContext();
        }

        public System.Data.Entity.DbSet<EAP_ASM_NTT.Models.Market> Markets { get; set; }

        public System.Data.Entity.DbSet<EAP_ASM_NTT.Models.Coin> Coins { get; set; }
    }
}