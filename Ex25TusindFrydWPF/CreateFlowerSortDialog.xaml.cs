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

namespace Ex25TusindFrydWPF
{
    /// <summary>
    /// Interaction logic for CreateFlowerSortDialog.xaml
    /// </summary>
    public partial class CreateFlowerSortDialog : Window
    {
        bool nameTextBoxNotEmpty, pictureTextBoxNotEmpty, productionTimeTextBoxNotEmpty, halfLifeTimeTextBoxNotEmpty, sizeTextBoxNotEmpty;
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            nameTextBoxNotEmpty = NameTextBox.Text.Length > 0;
            OKButton.IsEnabled = false;
            UpdateOKButtonState();
        }
        private void PictureTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            pictureTextBoxNotEmpty = PictureTextBox.Text.Length > 0;
            OKButton.IsEnabled = false;
            UpdateOKButtonState();
        }

        private void PictureTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                Uri resourceUri = new Uri(PictureTextBox.Text, UriKind.Absolute);

                PhotoFlowerSort.Source = new BitmapImage(resourceUri);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the image: " + ex.Message);
            }

        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ProductionTimeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            productionTimeTextBoxNotEmpty = ProductionTimeTextBox.Text.Length > 0;
            OKButton.IsEnabled = false;
            UpdateOKButtonState();
        }
        private void HalfLifeTimeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            halfLifeTimeTextBoxNotEmpty = HalfLifeTimeTextBox.Text.Length > 0;
            OKButton.IsEnabled = false;
            UpdateOKButtonState();
        }
        private void SizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            sizeTextBoxNotEmpty = SizeTextBox.Text.Length > 0;
            OKButton.IsEnabled = false;
            UpdateOKButtonState();
        }
        private void UpdateOKButtonState()
        {
            OKButton.IsEnabled = nameTextBoxNotEmpty && pictureTextBoxNotEmpty && productionTimeTextBoxNotEmpty && halfLifeTimeTextBoxNotEmpty && sizeTextBoxNotEmpty;
        }
        public string nameAnswer
        {
            get { return NameTextBox.Text; }
        }
        public string pictureAnswer
        {
            get { return PictureTextBox.Text; }
        }
        public string productionTimeAnswer
        {
            get { return ProductionTimeTextBox.Text; }
        }
        public string halfLifeTimeAnswer
        {
            get { return HalfLifeTimeTextBox.Text; }
        }
        public string sizeAnswer
        {
            get { return SizeTextBox.Text; }
        }


    }
}
