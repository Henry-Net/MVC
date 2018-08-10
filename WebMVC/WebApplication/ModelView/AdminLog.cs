using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication.ModelView
{
        [Table("AdminLog")]
    public class AdminLog
    {
        [Key,DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }
        public String UserName { get; set; }
        /// <summary>
        /// 操作时间
        /// System(前台), 用户名 
        /// </summary>
        public DateTime OPtime { get; set; }
        /// <summary>
        /// 操作 menu 
        /// 
        /// </summary>
        public String OPmenuName { get; set; }
        /// <summary>
        /// 操作类型 
        /// 
        /// </summary>
        public String OPtype { get; set; }
        /// <summary>
        /// 操作内容 要详细， 操作 id 存进去
        /// 
        /// </summary>
        public String Content { get; set; }
    }
}