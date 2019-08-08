using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketBooking.Models.Models;
using TicketBooking.BLL.BLL;

namespace TicketBooking.Controllers
{

    public class BranchController : Controller
    {
        BranchManager _branchManager = new BranchManager();
        // GET: Branch
        [HttpGet]
        public ActionResult Add()
        {
            return View(_branchManager.GetAll());
        }
        [HttpPost]
        public ActionResult Add(Branch branch)
        {
            bool isAdd =_branchManager.Add(branch);
            if (isAdd == true)
                ViewBag.msg = "Added Successfully!";
            else
                ViewBag.msg = "Sorry, Try Again!";
            return View(_branchManager.GetAll());
        }
    }
}