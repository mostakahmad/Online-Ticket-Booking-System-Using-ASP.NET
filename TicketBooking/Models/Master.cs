using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketBooking.Models.Models;

namespace TicketBooking.Models
{
    public class Master
    {
        public List<Branch> branches { get; set; }
        public List<Fair> fairs { get; set; }
    }
}