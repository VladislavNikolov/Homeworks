using C.CompanyHierarchy.Hierarchy;

namespace C.CompanyHierarchy.Interfaces
{
    public interface IEmployee : IPerson
    {
        Department Department { get; set; }
        decimal Salary { get;  set; }
    }
}