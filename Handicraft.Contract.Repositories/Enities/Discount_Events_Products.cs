using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Enities
{
    public class Discount_Events_Products
    {
        public required string id { get; set; }

        [JsonIgnore]
        public virtual Discount_Events?  Discount_Events{ get; set; }

        [JsonIgnore]
        public virtual Product? Product { get; set; }
    }
}
