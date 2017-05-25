using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFun.DTO
{
    public class GamePriceDTO
    {
        public int PriceID { get; set; }
        public int Game_SystemID { get; set; }
        public int PlayerNo { get; set; }
        public int Price { get; set; }
        public int Minutes { get; set; }
        public int IndividualPrice { get; set; }
    }
}
