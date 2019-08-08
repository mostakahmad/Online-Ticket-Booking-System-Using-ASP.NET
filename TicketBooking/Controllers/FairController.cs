using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBooking.BLL.BLL;
using TicketBooking.Models.Models;
using TicketBooking.Models;

namespace TicketBooking.Controllers
{
    public class FairController : Controller
    {
        BranchManager _branchManager = new BranchManager();
        FairManager _fairManager = new FairManager();
        Master _master = new Master();

        // GET: Fair
        [HttpGet]
        public ActionResult Add()
        {
            _master.branches = _branchManager.GetAll();
            _master.fairs = _fairManager.GetAll();
            return View(_master);
        }

        [HttpPost]
        public ActionResult Add(Fair fair)
        {
            bool isAdd = _fairManager.Add(fair);
            if (isAdd == true)
                ViewBag.msg = "Added Successfully!";
            else
                ViewBag.msg = "Sorry, Try Again!";

            _master.branches = _branchManager.GetAll();
            _master.fairs = _fairManager.GetAll();
            return View(_master);
        }

        public ActionResult GetFair(int FromBranchID, int ToBranchID)
        {
            var fair = _fairManager.GetFair(FromBranchID, ToBranchID);

            return Json(fair, JsonRequestBehavior.AllowGet);
        }
    }
}