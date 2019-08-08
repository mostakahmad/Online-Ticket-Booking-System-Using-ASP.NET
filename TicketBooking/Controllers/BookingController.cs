using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBooking.BLL.BLL;
using TicketBooking.Models.Models;

namespace TicketBooking.Controllers
{
    public class BookingController : Controller
    {
        BookingManager _bookingManager = new BookingManager();
        // GET: Booking
        [HttpPost]
        public ActionResult Add(Booking booking)
        {
            if(_bookingManager.Add(booking) == true)
            {
                ViewBag.msg = "Your Request Has Been Submitted. You Will Be Notified Soon!";
            }
            else
            {
                ViewBag.msg = "Sorry! Your Request Has Been Canceled!";
            }

            return RedirectToAction("index", "home");
        }
        public ActionResult BookingRequest()
        {
            return View(_bookingManager.BookingRequest());
        }

        public ActionResult Bookings()
        {
            return View(_bookingManager.Bookings());
        }
        public ActionResult Delete(int id)
        {
            _bookingManager.Delete(id);
            ViewBag.msg = "Sorry! Your Request Has Been Canceled!";
            return RedirectToAction("index", "home");
        }

        public ActionResult Confirm(int id)
        {
            _bookingManager.Confirm(id);
            ViewBag.msg = "Your Request Has Been Submitted. You Will Be Notified Soon!";
            return RedirectToAction("index", "home");
        }
    }
}