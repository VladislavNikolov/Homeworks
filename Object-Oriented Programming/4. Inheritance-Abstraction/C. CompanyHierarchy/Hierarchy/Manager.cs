using System;
using System.Collections.Generic;
using System.Text;
using C.CompanyHierarchy.Interfaces;

namespace C.CompanyHierarchy.Hierarchy
{
    public class Manager : Employee, IManager
    {
        private List<Employee> employeeList;

        public Manager(string firstname, string lastname, int id, decimal salary, Department department,
            List<Employee> employeeList)
            : base(firstname, lastname, id, salary, department)
        {
            this.EmployeeList = employeeList;
        }

        public List<Employee> EmployeeList
        {
            get
            {
                return new List<Employee>(this.employeeList);
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Employee List", "Employee List can not be empty.");
                }

                this.employeeList = new List<Employee>(value);
            }
        }

        public override string ToString()
        {
            StringBuilder employees = new StringBuilder();
            employees.AppendLine(" Employeses under command:");

            foreach (var employee in this.employeeList)
            {
                employees.AppendLine(employee.ToString());
            }

            return base.ToString() + employees;
        }
    }
}