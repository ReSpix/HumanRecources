using HumanResources;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace HumanResourcedDepartment
{
    /// <summary>
    /// Логика взаимодействия для DepartmentWindow.xaml
    /// </summary>
    public partial class DepartmentWindow : Window
    {
        private Department department;
        private string path;

        public DepartmentWindow(string path)
        {
            InitializeComponent();
            this.path = path;
            department = GetDepartment(path);
            EmployeesBox.ItemsSource = department.Employees;
            this.Title = department.Title;
        }

        private Department GetDepartment(string path)
        {
            return JsonSerializer.Deserialize<Department>(File.ReadAllText(path));
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(department);
            File.WriteAllText(path, json);
        }

        public void AddEmployee(Employee employee)
        {
            department.AddEmployee(employee);
            EmployeesBox.Items.Refresh();
            Save();
        }

        private void EditEmployeeClick(object sender, RoutedEventArgs e)
        {
            Employee emp = ((Button)sender).DataContext as Employee;
            int index = department.Employees.IndexOf(emp);
            EmployeeWindow employeeWindow = new EmployeeWindow(this, emp, index);
            employeeWindow.Show();
        }

        public void EditEmployee(Employee employee, int index)
        {
            department.Employees[index] = employee;
            EmployeesBox.Items.Refresh();
            Save();
        }

        private void RemoveEmployee(object sender, RoutedEventArgs e)
        {
            Employee emp = ((Button)sender).DataContext as Employee;
            department.RemoveEmployee(emp);
            EmployeesBox.Items.Refresh();
            Save();
        }

        private void AddEmployeeClick(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow(this);
            employeeWindow.Show();
        }
    }
}
