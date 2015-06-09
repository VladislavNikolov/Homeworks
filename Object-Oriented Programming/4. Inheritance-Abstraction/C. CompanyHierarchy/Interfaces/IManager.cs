using System.Collections.Generic;
using C.CompanyHierarchy.Hierarchy;

namespace C.CompanyHierarchy.Interfaces
{
    public interface IManager : IEmployee
    {
        List<Employee> EmployeeList { get; set; }
    }
}