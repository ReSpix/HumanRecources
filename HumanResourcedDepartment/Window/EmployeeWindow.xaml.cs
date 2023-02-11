using HumanResourcedDepartment;
using System.Windows;

namespace HumanResources
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        DepartmentWindow dpWindow;
        bool changing = false;
        int index = -1;

        public EmployeeWindow(DepartmentWindow sender)
        {
            InitializeComponent();
            dpWindow = sender;
        }

        public EmployeeWindow(DepartmentWindow sender, Employee employee, int index)
        {
            InitializeComponent();
            dpWindow = sender;

            changing = true;
            this.index = index;

            NameBox.Text = employee.Name;
            PassportBox.Text = employee.Passport;
            JobBox.Text = employee.Job;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            Employee emp = new Employee(NameBox.Text, PassportBox.Text, JobBox.Text);
            if (changing)
            {
                dpWindow.EditEmployee(emp, index);
            }
            else
            {
                dpWindow.AddEmployee(emp);
            }
            Close();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
