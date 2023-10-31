using Ex30e3.Commands;
using Ex30e3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex30e3.ViewModels
{
    internal class MainViewModel
    {
        public ProductRepository productRepo = new ProductRepository();
        public ObservableCollection<ProductViewModel> ProductsVM { get; set; } = new ObservableCollection<ProductViewModel>();
        private ProductViewModel _selectedProduct;
        public ProductViewModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { _selectedProduct = value; }
        }
        public ICommand NewProductCmd { get; set; } = new NewProductCommand();
        public ICommand DeleteProductCmd { get; set; } = new DeleteProductCommand();
        public MainViewModel()
        {
            ImportFromProductsToProductsVM();
        }
        private void ImportFromProductsToProductsVM()
        {
            foreach (Product product in productRepo.Products)
            {
                ProductsVM.Add(new ProductViewModel(product));
            }
        }
    }
}
