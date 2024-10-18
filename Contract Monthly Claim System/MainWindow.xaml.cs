using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lecturer_Click(object sender, RoutedEventArgs e)
        {
            LecturerWindow lecturerWindow = new LecturerWindow();
            lecturerWindow.Show();
            LecturerWindow sec = new LecturerWindow();
            sec.ShowDialog();
            this.Close();
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            AdminWindow sec = new AdminWindow();
            sec.ShowDialog();
            this.Close();
        }
    }
}