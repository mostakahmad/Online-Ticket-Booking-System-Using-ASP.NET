using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Models.Models;
using TicketBooking.Repository.Repository;

namespace TicketBooking.BLL.BLL
{
    public class BranchManager
    {
        BranchRepository _branchRepository = new BranchRepository();
        public bool Add(Branch branch)
        {
            return _branchRepository.Add(branch);
        }
        public List<Branch> GetAll()
        {
            return _branchRepository.GetAll();
        }
    }
}
