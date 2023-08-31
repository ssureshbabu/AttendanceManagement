using System.ComponentModel.DataAnnotations;

namespace AttendanceManagement.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeDesignation { get; set; }
        [Required]
        public DateTime EmployeeDOB { get; set; }
        [Required]
        public string EmployeeGender { get; set; }
        [Required]
        public string EmployeeAttendance { get; set; }
    }
}
