using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace leave_management.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string EmployeeId { get; set; }
        public LeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }

    public class CreateLeaveAllocationViewModel
    {
        public int NumberUpdated { get; set; }
        public List<LeaveTypeViewModel> LeaveType { get; set; }
    }

    public class EditLeaveAllocationViewModel
    {
        public int Id { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string EmployeeId { get; set; }
        [Display(Name = "Number Of Days")]
        [Range(1, 50, ErrorMessage = "Enter Valid Number")]
        public int NumberOfDays { get; set; }
        public LeaveTypeViewModel LeaveType { get; set; }

    }

    public class ViewAllocationsViewModel
    {
        public EmployeeViewModel Employee { get; set; }
        public string EmployeeId { get; set; }
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }
    }
}
