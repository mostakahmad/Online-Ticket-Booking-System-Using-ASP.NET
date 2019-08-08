using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Models.Models;
using TicketBooking.DatabaseContext.DatabaseContext;

namespace TicketBooking.Repository.Repository
{
    public class BookingRepository
    {
        TicketBookingDBContext db = new TicketBookingDBContext();
        public bool Add(Booking booking)
        {
            int isAdd = 0;

            db.bookings.Add(booking);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return true;
            return false;
        }

        public List<Booking> BookingRequest()
        {
            return db.bookings.Where(c=>c.Status == 0).ToList();
        }
        public List<Booking> Bookings()
        {
            return db.bookings.Where(c => c.Status == 1).ToList();
        }

        public bool Delete(int id)
        {
            int isDelete = 0;
            Booking booking = new Booking();

            booking = db.bookings.FirstOrDefault(c => c.BookingID == id);
            if (booking != null)
            {
                db.bookings.Remove(booking);
                isDelete = db.SaveChanges();
            }
            if (isDelete > 0)
                return true;
            return false;
        }
        public bool Confirm(int id)
        {
            int isConfirm = 0;
            Booking booking = new Booking();

            booking = db.bookings.FirstOrDefault(c => c.BookingID == id);
            if (booking != null)
            {
                booking.Status = 1;
                isConfirm = db.SaveChanges();
            }
            if (isConfirm > 0)
                return true;
            return false;
        }
    }
}
