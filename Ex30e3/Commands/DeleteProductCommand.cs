using Ex30e3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ex30e3.Commands
{
    internal class DeleteProductCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            bool result = true;
            if (parameter is MainViewModel mvm)
            {
                if (mvm.SelectedProduct == null)
                    result = false;
                else if (mvm.ProductsVM.Count == 0)
                    result = false;
            }

            CommandManager.InvalidateRequerySuggested();

            return result;
        }

        public void Execute(object? parameter)
        {
            if (parameter is MainViewModel mvm)
            {
                int index = mvm.ProductsVM.IndexOf(mvm.SelectedProduct);
                mvm.ProductsVM.RemoveAt(index);
                mvm.productRepo.Products.RemoveAt(index);
            }
        }
    }
}
