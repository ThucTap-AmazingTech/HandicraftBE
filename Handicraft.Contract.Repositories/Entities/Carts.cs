using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Entities
{
    public class Carts
    {
        public required string id { get; set; }
        //[JsonIgnore]
        //public virtual User user_id { get; set; }
        [JsonIgnore]
        public virtual ICollection<Products> product_id { get; set; }
        public int amount  { get; set; }

    }
}
