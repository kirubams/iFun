using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFun.DTO
{
    public class NumberOfSystemDTO
    {
        public int ID { get; set;}
        public int SystemOrderId { get; set; }
        public int Game_SystemID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int Createdby { get; set; }
        public int Modifiedby { get; set; }
    }
}
