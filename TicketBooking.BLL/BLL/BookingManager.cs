using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Models.Models;
using TicketBooking.Repository.Repository;

namespace TicketBooking.BLL.BLL
{
    public class BookingManager
    {
        BookingRepository _bookingRepository = new BookingRepository();
        public bool Add(Booking booking)
        {
            return _bookingRepository.Add(booking);
        }
        public List<Booking> BookingRequest()
        {
            return _bookingRepository.BookingRequest();
        }
        public List<Booking> Bookings()
        {
            return _bookingRepository.Bookings();
        }
        public bool Delete(int id)
        {
            return _bookingRepository.Delete(id);
        }
        public bool Confirm(int id)
        {
            return _bookingRepository.Confirm(id);
        }
    }
}
