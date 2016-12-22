using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.BusinessEntity
{
    public class FranchiseLocation : BaseEntity
    {
        public int countryId { get; set; }
        public int stateId { get; set; }
        public int cityId { get; set; }
        public int location { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string pinCode { get; set; }

    }
}
