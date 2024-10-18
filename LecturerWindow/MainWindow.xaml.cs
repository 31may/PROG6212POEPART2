using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace ContractMonthlyClaimSystem
{
    public partial class LecturerWindow : Window
    {
        public LecturerWindow()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == true)
            {
                statusTextBlock.Text = $"Uploaded: {openFileDialog.FileName}";
            }
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Simulate claim submission
            string month = (monthComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string amount = amountTextBox.Text;

            if (!string.IsNullOrWhiteSpace(month) && !string.IsNullOrWhiteSpace(amount))
            {
                statusTextBlock.Text = $"Claim for {month} submitted!";
            }
            else
            {
                statusTextBlock.Foreground = System.Windows.Media.Brushes.Red;
                statusTextBlock.Text = "Please complete all fields.";
                LecturerClaimSubmission sec = new LecturerClaimSubmission();
                sec.ShowDialog();
            }
        }
    }
}