using System;

namespace C.CompanyHierarchy.Interfaces
{
    public interface ISales
    {
        string ProductName { get; set; }
        DateTime ProductDate { get; set; }
        decimal Price { get; set; }
    }
}