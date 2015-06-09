using System;
using C.CompanyHierarchy.Hierarchy;

namespace C.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStart { get; set; }
        string Details { get; set; }
        ProjectState State { get; set; }

        void CloseProject();
    }
}