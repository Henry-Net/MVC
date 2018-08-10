using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.ModelView
{
    [Table("AdminRole_User")]
    [Serializable()]
    public class AdminRole_User
    {
        [Key, Column(Order = 2)]
        public int RoleId { get; set; }
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
    }
}