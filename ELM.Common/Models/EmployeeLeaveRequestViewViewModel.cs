using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM.Common.Models
{
    internal class EmployeeLeaveRequestViewViewModel
    {
        public EmployeeLeaveRequestViewViewModel(List<LeaveAllocationViewModel> leaveAllocations, List<LeaveRequestViewModel> leaveRequests)
        {
            LeaveAllocations = leaveAllocations;
            LeaveRequests = leaveRequests;
        }
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}
