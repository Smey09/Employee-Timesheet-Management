using EmployeeTimesheetManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTimesheetManagement.Features;

public class Timesheet {
    public List<Employee>? Employees { get; set; }
    public Timesheet() { Employees = new List<Employee>();}
    public void AddEmployee(Employee emp) {
        if (string.IsNullOrEmpty(emp.FullName) || string.IsNullOrEmpty(emp.FullName) || string.IsNullOrEmpty(emp.FullName) ||  string.IsNullOrEmpty(emp.CardNo))
            throw new ArgumentException("Please provide all employee's data");
        else
            Employees?.Add(emp);
    }
    public void UpdateEmployee(string IdentityId, string Fullname, string Position) { 
        if (string.IsNullOrEmpty(IdentityId) || string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Position)) 
            throw new ArgumentException("Please provide all employee's data");
        int foundIndex = Employees!.FindIndex(em => em.IdentityId == new Guid(IdentityId));
        Employees[foundIndex].FullName = Fullname;
        Employees[foundIndex].Position = Position;
    }
    public void LogEmployee(string CardNo, Log logInfo) {
        if (string.IsNullOrEmpty(CardNo))
            throw new ArgumentException("Card no is empty");
        int foundIndex = Employees!.FindIndex(em => em.CardNo == CardNo.Trim());
     
        if (foundIndex == -1)
            throw new ArgumentException($"Card No.{CardNo} not found in the Employee List.");
        Employees[foundIndex].Logs!.Add(logInfo);
    }
    public void RemoveEmployee(Guid identityID) {
        int foundIndex = Employees!.FindIndex(em => em.IdentityId == identityID);
        Employees.RemoveAt(foundIndex);
    }
    public List<EmployeeView> GetAllEmployees() {
        return Employees!.Select(em => new EmployeeView()
        {
            IndentityId = em.IdentityId,
            Fullname = em.FullName,
            Position = em.Position,
            CardNo = em.CardNo
        }).ToList();
    }
    public List<Employee> GetAllEmployees(bool isSimpleVersion) { return Employees!; }
}
