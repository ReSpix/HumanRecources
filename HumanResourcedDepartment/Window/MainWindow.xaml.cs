using System.Windows;

namespace HumanResourcedDepartment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DepartmentWindow dp = new DepartmentWindow("C:\\Users\\Yanovich\\Documents\\HR\\selling.txt");
            dp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DepartmentWindow dp = new DepartmentWindow("C:\\Users\\Yanovich\\Documents\\HR\\marketing.txt");
            dp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DepartmentWindow dp = new DepartmentWindow("C:\\Users\\Yanovich\\Documents\\HR\\hr.txt");
            dp.Show();
        }
    }
}
