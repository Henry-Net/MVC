using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication.ModelView;

namespace WebApplication.DAL
{
    public class AccountContext : DbContext
    {
        public AccountContext()
            : base("name = DB_AA")
        {
        }

        public DbSet<AdminRole_User> AdminRole_Users { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }
        public DbSet<AdminLog> AdminLogs { get; set; }
    }
}