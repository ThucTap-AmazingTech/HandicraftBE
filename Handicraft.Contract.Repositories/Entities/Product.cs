using Handicraft.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Handicraft.Contract.Repositories.Entities
{
    public class Product : BaseEntity
    {     
        public string? Name { get; set; }
        public string? Size { get; set; }
        public string? Material { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string? CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
        [JsonIgnore]
        public virtual ICollection<Image>? Images { get; }
    }
}
