using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Models.Models;
using TicketBooking.Repository.Repository;

namespace TicketBooking.BLL.BLL
{
    public class FairManager
    {
        FairRepository _fairRepository = new FairRepository();
        public bool Add(Fair fair)
        {
            return _fairRepository.Add(fair);
        }
        public List<Fair> GetAll()
        {
            return _fairRepository.GetAll();
        }
        public List<Fair> GetFair(int FromBranchID, int ToBranchID)
        {
            return _fairRepository.GetFair(FromBranchID, ToBranchID);
        }
    }
}
