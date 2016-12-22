using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.BusinessEntity
{
    public class Users : BaseEntity
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string permanentAddress { get; set; }
        public string profileImagePath { get; set; }
        public string profileImageName { get; set; }
        public int userTypeId { get; set; }
    }
}
