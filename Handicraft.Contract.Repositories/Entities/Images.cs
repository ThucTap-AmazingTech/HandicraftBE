using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handicraft.Repositories.Entities
{
    public class Images
    {
        public string? ProductId { get; set; }
        public string? FileName { get; set; }
        public Products? Product { get; set; }
    }
}
