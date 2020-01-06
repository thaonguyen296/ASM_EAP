using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EAP_ASM_NTT.Models
{
    public class AccountRole : IdentityRole
    {
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}