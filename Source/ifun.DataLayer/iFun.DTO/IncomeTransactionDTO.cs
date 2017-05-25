using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFun.DTO
{
    public class IncomeTransactionDTO
    {
        public int IncomeTransactionID { get; set; }
        public int SystemOrderId { get; set; }
        public int Minutes { get; set; }
        public int Game_SystemID { get; set; }
        public int noOfPlayers { get; set; }
        public bool isIndividual { get; set; }
        public bool isManual { get; set; }
        public int ManualPrice { get; set; }
        public string Comments { get; set; }
        public int FinalPrice { get; set; }
        public int Createdby { get; set; }
        public string GameSystemDescription { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
