using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.ViewModels
{
    public class CategoryVM
    {
        public Category Category { get; set; } = new Category();
        [ValidateNever]
        public IEnumerable<Category> categories { get; set; } = new List<Category>(); 
    }

   
}
