using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.ModelView
{
    public class SysUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual ICollection<SysUserRole> SysUserRole { get; set; }
    }
}