using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Enities
{
    public class Discount_Events
    {
        public required string id { get; set; }
        public DateTime start_date  { get; set; }
        public DateTime end_date { get; set; }
        public string? description { get; set; }
        public float discount_percent { get; set; }
        public double discount_price { get; set; }

    }
}
