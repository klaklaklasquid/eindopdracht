using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Eindopdracht.Presentation.Windows.Gegevensinitialisatie {
    /// <summary>
    /// Interaction logic for InitialisatieGegevens.xaml
    /// </summary>
    public partial class InitialisatieGegevens : Window {
        public InitialisatieGegevens() {
            InitializeComponent();
        }

        private void SelectVestiging_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                FilePathTextBoxVestiging.Text = filePath;
            }
        }
        private void SelectCar_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                FilePathTextBoxCar.Text = filePath;
            }
        }
        private void SelectCustomer_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true) {
                string filePath = openFileDialog.FileName;
                FilePathTextBoxCustomer.Text = filePath;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }
    }
}
