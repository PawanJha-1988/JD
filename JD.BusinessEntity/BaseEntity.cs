using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JD.BusinessEntity
{
    public abstract class BaseEntity
    {
        public Int64 ID { get; set; }
        // [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime CreatedDate { get; set; }
        //[DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime UpdatedDate { get; set; }
        public int createdBy { get; set; }
        public int updatedBy { get; set; }
        public int iP { get; set; }

    }
}
