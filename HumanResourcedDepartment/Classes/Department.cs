using System.Collections.Generic;

namespace HumanResourcedDepartment
{
    public class Department
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Employee> Employees { get; set; }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}
