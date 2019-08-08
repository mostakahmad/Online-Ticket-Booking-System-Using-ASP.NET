using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TicketBooking.Models.Models;

namespace TicketBooking.DatabaseContext.DatabaseContext
{
    public class TicketBookingDBContext : DbContext
    {
        public DbSet<Branch> branches { get; set; }
        public DbSet<Fair> fairs { get; set; }
        public DbSet<Booking> bookings { get; set; }
    }
}
