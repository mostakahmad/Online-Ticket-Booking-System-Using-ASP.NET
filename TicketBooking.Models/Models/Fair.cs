using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Models.Models
{
    public class Fair
    {
        public int FairID { get; set; }
        public string FromBranch { get; set; }
        public int FromBranchID { get; set; }
        public string ToBranch { get; set; }
        public int ToBranchID { get; set; }
        public int AC { get; set; }
        public int NonAC { get; set; }
    }
}
