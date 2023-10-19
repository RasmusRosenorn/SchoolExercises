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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ex24WPF
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
            string Line1Placeholder = Line1.Text;
            Line1.Text = Line2.Text;
            Line2.Text = Line3.Text;
            Line3.Text = Line4.Text;
            Line4.Text = Line1Placeholder;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Line4Placeholder = Line4.Text;
            Line4.Text = Line3.Text;
            Line3.Text = Line2.Text;
            Line2.Text = Line1.Text;
            Line1.Text = Line4Placeholder;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Line1.Text = Line2.Text = Line3.Text = Line4.Text = "";
        }
    }
}
