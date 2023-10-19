using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM.Common.Models
{
    public class LeaveAllocationEditViewModel
    {
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public EmployeeListViewModel? Employee { get; set; }
    }
}
