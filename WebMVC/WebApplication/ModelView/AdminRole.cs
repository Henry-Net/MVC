using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.ModelView
{
    [Table("AdminRole")]
    [Serializable()]
    public class AdminRole
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreateTime { get; set; }
        [NotMapped]
        public Dictionary<int, string> MemberDic { get; set; }
        /// <summary>
        /// 表示用户是否拥有此权限 操作方便
        /// </summary>
        [NotMapped]
        public bool IsSelected { get; set; }
    }
}