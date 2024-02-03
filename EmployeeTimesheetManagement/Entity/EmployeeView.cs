using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTimesheetManagement.Entity;

public class EmployeeView {
    public Guid IndentityId { get; set; }
    public string? Fullname { get; set; }
    public string? Position { get; set; }
    public string? CardNo { get; set; }
}
