using AttendanceManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceManagement.Data
{
    public class AttendanceModel : DbContext
    {
        public AttendanceModel(DbContextOptions<AttendanceModel> options) : base(options)
        { 
        }
        public DbSet<Employee> Employee { get; set; } 

    }
}
