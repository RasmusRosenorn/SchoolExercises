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

namespace WPFInteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
        }

      

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(controller.PersonCount > 0)
                controller.CurrentPerson.FirstName = FirstName.Text;
        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.PersonCount > 0)
                controller.CurrentPerson.LastName = LastName.Text;
        }

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.PersonCount > 0)
            {
                int i;
                if (int.TryParse(Age.Text, out i))
                {
                    controller.CurrentPerson.Age = i;
                }
            }
        }

        private void TelephoneNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (controller.PersonCount > 0)
                controller.CurrentPerson.TelephoneNo = TelephoneNo.Text;
        }

        private void NewPerson_Click(object sender, RoutedEventArgs e)
        {
            controller.AddPerson();
            PersonCountLabel.Content = "Person Count: " + controller.PersonCount;
            IndexLabel.Content = "Index: " + controller.PersonIndex;

            FirstName.Text = "";
            LastName.Text = "";
            Age.Text = "";
            TelephoneNo.Text = "";

            if (controller.PersonCount == 1)
            {
                FirstName.IsEnabled = true;
                LastName.IsEnabled = true;
                Age.IsEnabled = true;
                TelephoneNo.IsEnabled = true;
                DeletePerson.IsEnabled = true;
                Up.IsEnabled = true;
                Down.IsEnabled = true;
            }
        }

        private void DeletePerson_Click(object sender, RoutedEventArgs e)
        {
            controller.DeletePerson();
            if (controller.PersonCount == 0)
            {
                FirstName.Text = "";
                LastName.Text = "";
                Age.Text = "";
                TelephoneNo.Text = "";
            }
            else
            {
                FirstName.Text = controller.CurrentPerson.FirstName;
                LastName.Text = controller.CurrentPerson.LastName;
                Age.Text = controller.CurrentPerson.Age.ToString();
                TelephoneNo.Text = controller.CurrentPerson.TelephoneNo;
            }
            

            PersonCountLabel.Content = "Person Count: " + controller.PersonCount;
            IndexLabel.Content = "Index: " + controller.PersonIndex;

            if (controller.PersonCount == 0)
            {
                FirstName.IsEnabled = false;
                LastName.IsEnabled = false;
                Age.IsEnabled = false;
                TelephoneNo.IsEnabled = false;
                DeletePerson.IsEnabled = false;
                Up.IsEnabled = false;
                Down.IsEnabled = false;
            }
        }

            private void Up_Click(object sender, RoutedEventArgs e)
        {
            controller.NextPerson();
            IndexLabel.Content = "Index: " + controller.PersonIndex;
            FirstName.Text = controller.CurrentPerson.FirstName;
            LastName.Text = controller.CurrentPerson.LastName;
            Age.Text = controller.CurrentPerson.Age.ToString();
            TelephoneNo.Text = controller.CurrentPerson.TelephoneNo;

        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            controller.PrevPerson();
            IndexLabel.Content = "Index: " + controller.PersonIndex;
            FirstName.Text = controller.CurrentPerson.FirstName;
            LastName.Text = controller.CurrentPerson.LastName;
            Age.Text = controller.CurrentPerson.Age.ToString();
            TelephoneNo.Text = controller.CurrentPerson.TelephoneNo;
        }
    }
}
