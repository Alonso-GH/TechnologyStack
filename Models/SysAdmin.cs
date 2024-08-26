using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class SysAdmin
    {
        /// <summary>
        /// 管理员ID
        /// </summary>
        public int LoginId { get; set; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string AdminName { get; set; }
    }
}
