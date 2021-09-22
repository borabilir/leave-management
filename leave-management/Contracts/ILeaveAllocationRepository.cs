using leave_management.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        Task<bool> CheckAllocation(int leaveTypeId, string employeeId);
        Task<ICollection<LeaveAllocation>> GetLeaveAllocationsByEmployee(string id);
        Task<LeaveAllocation> GetLeaveAllocationsByEmployeeAndType(string employeeid, int leavetypeid);
    }
}
