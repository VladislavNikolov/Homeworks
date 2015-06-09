using C.CompanyHierarchy.Interfaces;

namespace C.CompanyHierarchy.Hierarchy
{
    public abstract class RegularEmployee : Employee, IRegularEmployee
    {
        protected RegularEmployee(string firstname, string lastname, int id, decimal salary, Department department)
            : base(firstname, lastname, id, salary, department)
        {
        }
    }
}