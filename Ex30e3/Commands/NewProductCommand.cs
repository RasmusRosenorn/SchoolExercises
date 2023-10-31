using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Ex30e3.Models;
using Ex30e3.ViewModels;

namespace Ex30e3.Commands
{
    internal class NewProductCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                Product product = new Product() { Name = "New Product", Price = 0.0 };
                mvm.productRepo.Products.Add(product);
                ProductViewModel productViewModel = new ProductViewModel(product);
                mvm.ProductsVM.Add(productViewModel);
            }
        }
    }
}
