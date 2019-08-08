using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBooking.Models.Models;
using TicketBooking.BLL.BLL;

namespace TicketBooking.Controllers
{
    public class HomeController : Controller
    {
        BranchManager _branchManager = new BranchManager();
        // GET: Home
        public ActionResult Index()
        {
            return View(_branchManager.GetAll());
        }
    }
}