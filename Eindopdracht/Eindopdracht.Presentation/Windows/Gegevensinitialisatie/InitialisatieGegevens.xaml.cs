using Eindopdracht.Logic.Managers;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace Eindopdracht.Presentation.Windows.Gegevensinitialisatie {
    /// <summary>
    /// Interaction logic for InitialisatieGegevens.xaml
    /// </summary>
    public partial class InitialisatieGegevens : Window {
        private readonly FileValidationManager _fileValidationManager;
        List<string> filePaths = new List<string>();

        public InitialisatieGegevens() {
            InitializeComponent();
            _fileValidationManager = new FileValidationManager();
        }

        private void SelectVestiging_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                FilePathTextBoxVestiging.Text = filePath;
                filePaths.Add(filePath);
            }
        }
        private void SelectCar_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                FilePathTextBoxCar.Text = filePath;
                filePaths.Add(filePath);
            }
        }
        private void SelectCustomer_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                FilePathTextBoxCustomer.Text = filePath;
                filePaths.Add(filePath);
            }
        }

        private void FilledIn(object sender, TextChangedEventArgs e) {
            SendButton.IsEnabled =
                !string.IsNullOrWhiteSpace(FilePathTextBoxVestiging.Text) &&
                !string.IsNullOrWhiteSpace(FilePathTextBoxCar.Text) &&
                !string.IsNullOrWhiteSpace(FilePathTextBoxCustomer.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if(_fileValidationManager.ValidatePath(filePaths)) {
                MessageBox.Show("Bestanden zijn geldig.");
            } else {
                MessageBox.Show("Een of meer bestanden zijn ongeldig.");
            }
        }
    }
}
