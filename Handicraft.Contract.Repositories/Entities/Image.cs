using Handicraft.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.Contract.Repositories.Entities
{
    public class Image : BaseEntity
    {
        public string? ProductId { get; set; }
        public string? FileName { get; set; }
        public virtual Product? Product { get; set; }
    }
}
