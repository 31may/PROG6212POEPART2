using System.Windows;

namespace CMCS
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            LoadPendingClaims();
        }

        private void LoadPendingClaims()
        {
            // Simulate loading pending claims (replace with database call in real app)
            claimsListView.Items.Add(new { ClaimID = "001", LecturerName = "John Doe", HoursWorked = "10", HourlyRate = "50" });
            claimsListView.Items.Add(new { ClaimID = "002", LecturerName = "Jane Smith", HoursWorked = "8", HourlyRate = "45" });
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Approved");
        }

        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Rejected");
        }
    }
}
