using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.ModelView
{
    public class SysUserRole
    {
        public int ID { get; set; }
        public int SysRoleId { get; set; }
        public int SysUserId { get; set; }
        public virtual SysRole SysRole { get; set; }
        public virtual SysUser SysUser { get; set; }
    }
}