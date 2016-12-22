using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.BusinessEntity
{
    public class City : BaseEntity
    {
        public int countryId { get; set; }
        public int stateId { get; set; }
        public int cityName { get; set; }
    }
}
