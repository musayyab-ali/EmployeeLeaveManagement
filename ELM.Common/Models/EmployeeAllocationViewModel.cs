using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM.Common.Models
{
    public class EmployeeAllocationViewModel : EmployeeListViewModel
    {
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
    }
}
