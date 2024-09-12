using Handicraft.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Entities
{
    public class DiscountEventsProduct : BaseEntity
    {
        [JsonIgnore]
        public virtual DiscountEvent?  DiscountEvents{ get; set; }

        [JsonIgnore]
        public virtual Product? Product { get; set; }
    }
}
