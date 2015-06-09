using System.Collections.Generic;
using C.CompanyHierarchy.Hierarchy;

namespace C.CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee : IRegularEmployee
    {
        List<Sales> SalesList { get; set; }
    }
}