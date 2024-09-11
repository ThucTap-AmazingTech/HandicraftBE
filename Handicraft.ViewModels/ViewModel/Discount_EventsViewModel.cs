using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.ViewModels.ViewModel
{
    public class Discount_EventsViewModel
    {
        public  string id { get; private set; }
        public DateTimeOffset start_date { get; set; }
        public DateTimeOffset end_date { get; set; }
        public string? description { get; set; }
        public float? discount_percent { get; set; }
        public double? discount_price { get; set; }
    }
}
