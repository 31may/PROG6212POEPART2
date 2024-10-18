using System.Windows;

namespace ContractMonthlyClaimSystem
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Simulate loading claims (this would be replaced with actual data in a full implementation)
            claimListView.Items.Add(new { ClaimID = "001", LecturerName = "John Doe", Month = "January", Amount = "1000" });
            claimListView.Items.Add(new { ClaimID = "002", LecturerName = "Jane Smith", Month = "February", Amount = "1200" });
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