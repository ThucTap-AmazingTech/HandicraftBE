using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Handicraft.ViewModels.ViewModels;

namespace Handicraft.ViewModels.ViewModel
{
    public class DiscountEventsProductsViewModel
    {
        public string? Id { get; private set; }
        public virtual DiscountEventsViewModel? DiscountEventsInfo { get; set; } = new DiscountEventsViewModel();
        public virtual ProductsViewModel? ProductInfo { get; set; } = new ProductsViewModel ();
    }
}
