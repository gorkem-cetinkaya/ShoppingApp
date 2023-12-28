// OrderViewModel.cs
using System.Collections.Generic;
using ShoppingApp.Models;

namespace ShoppingApp.ViewModels
{
    public class OrderViewModel
    {
        public List<Product> Products { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
