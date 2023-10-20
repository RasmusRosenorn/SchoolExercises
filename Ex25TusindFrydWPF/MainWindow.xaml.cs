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

namespace Ex25TusindFrydWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSortList;
        public MainWindow()
        {
            InitializeComponent();
            flowerSortList = new List<FlowerSort>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSortDialog = new CreateFlowerSortDialog();
            if (createFlowerSortDialog.ShowDialog() == true);
            {
                int productionTimeAnswer = int.Parse(createFlowerSortDialog.productionTimeAnswer);
                int halfLifeTimeAnswer = int.Parse(createFlowerSortDialog.halfLifeTimeAnswer);
                int sizeAnswer = int.Parse(createFlowerSortDialog.sizeAnswer);
                FlowerSort flowerSort = new FlowerSort(createFlowerSortDialog.nameAnswer, createFlowerSortDialog.pictureAnswer, 
                                                       productionTimeAnswer, halfLifeTimeAnswer, sizeAnswer);
                flowerSortList.Add(flowerSort);
                if (tbFlowers.Text.Length == 29)
                {
                    tbFlowers.Text = "";
                }
                tbFlowers.Text += flowerSort.Name + " \n";
            }

        }
    }
}
