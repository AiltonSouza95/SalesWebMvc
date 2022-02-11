using SalesWebMvc.Domain.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Views.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
