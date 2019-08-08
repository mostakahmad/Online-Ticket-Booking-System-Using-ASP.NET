using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Models.Models;
using TicketBooking.DatabaseContext.DatabaseContext;

namespace TicketBooking.Repository.Repository
{
    public class BranchRepository
    {
        TicketBookingDBContext db = new TicketBookingDBContext();
        public bool Add(Branch branch)
        {
            int isAdd = 0;

            db.branches.Add(branch);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return true;
            return false;
        }
        public List<Branch> GetAll()
        {
            return db.branches.ToList();
        }
    }
}
