using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Staff
    {
        public string StaffName { get; set; }//名称
        public string Grender { get; set; }//性别
        public DateTime Birthday { get; set; }//生日
        public string JobNum { get; set; }//工号
        public string StaffIamage { get; set; }//照片
        public int Age { get; set; }//年龄
        public string Phone { get; set; }//电话
        public string StaffAddress { get; set; }//地址
        public int DepartmentId { get; set; }
        public string Department { get; set; }//部门
        public int PostId { get; set; }
        public string Post { get; set; }// 岗位
        public int EducationId { get; set; }
        public string Education { get; set; }//学历
        public string IdentityNum { get; set; }//身份证
    }
}
