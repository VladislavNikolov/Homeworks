using System.Collections.Generic;
using C.CompanyHierarchy.Hierarchy;

namespace C.CompanyHierarchy.Interfaces
{
    public interface IDeveloper : IRegularEmployee
    {
        List<Project> ProjectsList { get; set; }
    }
}