﻿using Handicraft.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Entities
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<Product>? Products { get; }
    }
}
