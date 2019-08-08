using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Models.Models;
using TicketBooking.DatabaseContext.DatabaseContext;

namespace TicketBooking.Repository.Repository
{
    public class FairRepository
    {
        TicketBookingDBContext db = new TicketBookingDBContext();
        public bool Add(Fair fair)
        {
            int isAdd = 0;

            db.fairs.Add(fair);
            isAdd = db.SaveChanges();
            if (isAdd > 0)
                return true;
            return false;
        }
        public List<Fair> GetAll()
        {
            return db.fairs.ToList();
        }
        public List<Fair> GetFair(int FromBranchID, int ToBranchID)
        {
            return db.fairs.Where(c => c.FromBranchID >= FromBranchID && c.ToBranchID <= ToBranchID).ToList();
        }
    }
}
