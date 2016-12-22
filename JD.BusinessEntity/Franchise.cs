using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.BusinessEntity
{
    public class Franchise : BaseEntity
    {
        public string brandName { get; set; }
        public int franchiseType { get; set; }
        public string imagePath { get; set; }
        public string imageName { get; set; }
    }
}
