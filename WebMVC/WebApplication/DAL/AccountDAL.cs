using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.ModelView;

namespace WebApplication.DAL
{
    public class AccountDAL
    {
        public List<AdminLog> GetAllAdminLog()
        {
            using (var context = new AccountContext())
            {
                return context.AdminLogs.Where(a=>a.Id==85).ToList();
            }
        }
    }
}