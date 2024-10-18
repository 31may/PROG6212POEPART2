using Microsoft.Win32;
using System.Windows;

namespace CMCS
{
    public partial class LecturerWindow : Window
    {
        private string uploadedFilePath;

        public LecturerWindow()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Document Files (*.pdf, *.docx, *.xlsx)|*.pdf;*.docx;*.xlsx",
                Title = "Upload Supporting Document"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                uploadedFilePath = openFileDialog.FileName;
                uploadedFileName.Text = $"Uploaded: {openFileDialog.SafeFileName}";
            }
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            string hoursWorked = hoursWorkedTextBox.Text;
            string hourlyRate = hourlyRateTextBox.Text;
            string notes = notesTextBox.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(hoursWorked) || string.IsNullOrWhiteSpace(hourlyRate))
            {
                MessageBox.Show("Please complete all required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Simulate saving the claim (this would be sent to a database in a real app)
            string claimSummary = $"Submitted Claim:\nHours Worked: {hoursWorked}\nHourly Rate: {hourlyRate}\nNotes: {notes}";
            if (!string.IsNullOrWhiteSpace(uploadedFilePath))
            {
                claimSummary += $"\nSupporting Document: {uploadedFilePath}";
            }

            MessageBox.Show(claimSummary, "Claim Submitted", MessageBoxButton.OK, MessageBoxImage.Information);

            // Clear the form after submission
            hoursWorkedTextBox.Text = string.Empty;
            hourlyRateTextBox.Text = string.Empty;
            notesTextBox.Text = string.Empty;
            uploadedFileName.Text = "No file uploaded";
        }
    }
}