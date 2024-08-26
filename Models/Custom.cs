using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Custom
    {
        public string PartnerID { get; set; }//客户ID
        public string CustomName { get; set; }//客户名称
        public string PartnerType { get; set; }//客户类型
        public string JobNum { get; set; }//工号
        public DateTime UpdateTime { get; set; }//更新时间
        //扩展属性
        public string StaffName { get; set; }//名称
        public string Grender { get; set; }//性别
        public DateTime Birthday { get; set; }//生日
        public string StaffIamage { get; set; }//照片
        public int Age { get; set; }//年龄
        public string Phone { get; set; }//电话
        public string StaffAddress { get; set; }//地址
        public int DepartmentId { get; set; }
        public int PostId { get; set; }
        public int EducationId { get; set; }
        public string IdentityNum { get; set; }//身份证
        public string DepartmentName { get; set; }//部门
        public string EducationName { get; set; }//学历
        public string PostName { get; set; }//职位
    }
}
