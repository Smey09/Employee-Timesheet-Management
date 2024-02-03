using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTimesheetManagement.Entity;

public class Employee {
    public Guid IdentityId { get; set; }
    public string? FullName { get; set; }
    public string? Position { get; set; }
    public string? CardNo { get; set; }
    public IList<Log>? Logs { get; set; }
    public Employee() { }
    public Employee(string? fullName, string? position, string? cardNo)
    {
        IdentityId = Guid.NewGuid();
        FullName = fullName;
        Position = position;
        CardNo = cardNo;
        Logs = new List<Log>();
    }
}
