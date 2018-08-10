using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.ModelView
{
    public class SysRole
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<SysUserRole> SysUserRole { get; set; }
    }
}