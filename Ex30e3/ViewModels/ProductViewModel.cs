using Ex30e3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex30e3.ViewModels
{
    internal class ProductViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductViewModel(Product product)
        {
            Name = product.Name;
            Price = product.Price;
        }
    }
}
