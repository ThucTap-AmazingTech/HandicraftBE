using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handicraft.ViewModels.ViewModel
{
    public class Discount_Events_ProductsViewModel
    {
        public string id { get; private set; }
        public virtual Discount_EventsViewModel? Discount_EventsInfo { get; set; } = new Discount_EventsViewModel();
        public virtual ProductsViewModel? ProductInfo { get; set; } = new ProductsViewModel ();
    }
}
