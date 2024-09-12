using Handicraft.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Entities
{
    public class Cart : BaseEntity
    {
        [JsonIgnore]
        public virtual User? User { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product>? Products { get; set; }
        public int Amount { get; set; }

    }
}
