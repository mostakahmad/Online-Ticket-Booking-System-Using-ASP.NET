using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBooking.Models.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string FromBranch { get; set; }
        public string ToBranch { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public int Price { get; set; }
        public int Status { get; set; }
    }
}
