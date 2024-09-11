using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.ViewModels.ViewModel
{
    public class CartsViewModel
    {
        public string Id { get; private set; }       
        public UsersViewModel UserInfo { get; set; }  =  new UsersViewModel();
        public List<ProductsViewModel> ListProduct { get; set; } = new List<ProductsViewModel>();
        public int Amount { get; set; }
    }
}
